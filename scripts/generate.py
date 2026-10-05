"""Generate additive, dependency-free C# APIs from the checked-in unit catalog.

Python standard library only. Inputs are pinned; generation never uses the network.
Existing enum IDs and direct helper methods are a compatibility contract.
"""
import ast
import copy
import json
import math
import re
from fractions import Fraction as F
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
SRC = ROOT / 'src/UnitConverter'
LEGACY = json.loads((ROOT/'data/legacy-api.json').read_text())
UPSTREAM = json.loads((ROOT/'data/upstream/unitsnet.json').read_text())
PREFIXES = dict(zip('Femto Pico Nano Micro Milli Centi Deci Deca Hecto Kilo Mega Giga Tera Peta Exa'.split(), zip([-15,-12,-9,-6,-3,-2,-1,1,2,3,6,9,12,15,18], ['f','p','n','µ','m','c','d','da','h','k','M','G','T','P','E'])))
PREFIX_LOCAL = {
 'ru-RU': dict(zip('Femto Pico Nano Micro Milli Centi Deci Deca Hecto Kilo Mega Giga Tera Peta Exa'.split(), 'ф п н мк м с д да г к М Г Т П Э'.split())),
 'zh-CN': dict(zip('Femto Pico Nano Micro Milli Centi Deci Deca Hecto Kilo Mega Giga Tera Peta Exa'.split(), '飞 皮 纳 微 毫 厘 分 十 百 千 兆 吉 太 拍 艾'.split()))}
for i,p in enumerate('Kibi Mebi Gibi Tebi Pebi Exbi'.split(),1): PREFIXES[p]=(None, p[:2])

def cs(s): return json.dumps(s,ensure_ascii=False)
def write(path,s):
    p=ROOT/path; p.parent.mkdir(parents=True,exist_ok=True); p.write_text(s,encoding='utf-8')
def camel(s): return s[0].lower()+s[1:]
def display(s): return re.sub(r'(?<=[a-z0-9])(?=[A-Z])',' ',s)
def clean(e):
    e=e.replace('{x}','x').replace('System.Math.','Math.').replace('Math.PI','3.1415926535897932384626433833')
    return re.sub(r'(?<=[0-9])[dDmM]\b','',e)
def expr(e,variable='value'):
    # Double suffixes also prevent integer division in constant subexpressions.
    e=e.replace('{x}',variable).replace('System.Math.','Math.')
    return re.sub(r'(?<![\w.])((?:\d+(?:\.\d*)?|\.\d+)(?:[eE][+-]?\d+)?)(?:[dDmM])?(?![\w.])',r'\1d',e)

def poly_add(a,b):
    r=[F(0)]*max(len(a),len(b))
    for i,x in enumerate(a):r[i]+=x
    for i,x in enumerate(b):r[i]+=x
    while len(r)>1 and r[-1]==0:r.pop()
    return r
def poly_mul(a,b):
    r=[F(0)]*(len(a)+len(b)-1)
    for i,x in enumerate(a):
        for j,y in enumerate(b):r[i+j]+=x*y
    while len(r)>1 and r[-1]==0:r.pop()
    return r
def rational(e):
    source=clean(e).strip()
    # Canonical SI powers remove round-trip binary serialization noise in the legacy data.
    def canonical_power(match):
        token=match[0]; number=float(token)
        if number<=0:return token
        exponent=round(math.log10(number)); power=10.0**exponent
        return '1e'+str(exponent) if abs(number/power-1)<3e-16 else token
    source=re.sub(r'(?<![\w.])(?:\d+\.\d+(?:[eE][+-]?\d+)?|\d+[eE][+-]?\d+)(?![\w.])',canonical_power,source)
    def visit(n):
        if isinstance(n,ast.Constant):return [F(ast.get_source_segment(source,n))],[F(1)]
        if isinstance(n,ast.Name) and n.id=='x':return [F(0),F(1)],[F(1)]
        if isinstance(n,ast.UnaryOp):
            a,b=visit(n.operand)
            if isinstance(n.op,ast.USub):a=[-x for x in a]
            return a,b
        if isinstance(n,ast.BinOp):
            a,b=visit(n.left);c,d=visit(n.right)
            if isinstance(n.op,ast.Add):return poly_add(poly_mul(a,d),poly_mul(c,b)),poly_mul(b,d)
            if isinstance(n.op,ast.Sub):return poly_add(poly_mul(a,d),[-x for x in poly_mul(c,b)]),poly_mul(b,d)
            if isinstance(n.op,ast.Mult):return poly_mul(a,c),poly_mul(b,d)
            if isinstance(n.op,ast.Div):return poly_mul(a,d),poly_mul(b,c)
        if isinstance(n,ast.Call) and isinstance(n.func,ast.Attribute) and n.func.attr=='Pow':
            a,b=visit(n.args[0]);c,d=visit(n.args[1]); power=c[0]/d[0]
            if len(a)==len(b)==len(c)==len(d)==1 and power.denominator==1:
                v=(a[0]/b[0])**int(power);return [v],[F(1)]
        raise ValueError('Non-rational conversion: '+e)
    try:
        a,b=visit(ast.parse(source,mode='eval').body)
        if len(a)>2 or len(b)>2:return None
        a+= [F(0)]*(2-len(a));b+=[F(0)]*(2-len(b))
        values=[a[0],a[1],b[0],b[1]]
        common=math.lcm(*(v.denominator for v in values))
        out=[int(v*common) for v in values]
        gcd=math.gcd(*out);return [v//gcd for v in out]
    except (ValueError,ZeroDivisionError):return None

def expanded(d):
    for u in d['Units']:
        yield copy.deepcopy(u)
        for prefix in u.get('Prefixes',[]):
            v=copy.deepcopy(u); power,symbol=PREFIXES[prefix]
            factor=str(1024**('Kibi Mebi Gibi Tebi Pebi Exbi'.split().index(prefix)+1)) if power is None else '1e'+str(power)
            v['SingularName']=prefix+camel(u['SingularName']);v['PluralName']=prefix+camel(u['PluralName'])
            v['FromUnitToBaseFunc']='('+u['FromUnitToBaseFunc']+') * '+factor
            v['FromBaseToUnitFunc']='('+u['FromBaseToUnitFunc']+') / '+factor
            for loc in v.get('Localization',[]):
                local=PREFIX_LOCAL.get(loc['Culture'],{}).get(prefix,symbol)
                explicit=loc.get('AbbreviationsForPrefixes',{}).get(prefix)
                loc['Abbreviations']=explicit or [local+x for x in loc['Abbreviations']]
            yield v

def make_model():
    families={f['name']:copy.deepcopy(f) for f in LEGACY['families']}
    for f in families.values():
        f['dimensions']=None
        for u in f['units']:u['aliases']={'en-US':[u['symbol']]}
    for entry in UPSTREAM['definitions']:
        d=entry['definition'];n=d['Name']; f=families.setdefault(n,dict(name=n,base=d['BaseUnit'],units=[],helpers={}))
        f['dimensions']=d.get('BaseDimensions',{})
        f['summary']=d.get('XmlDocSummary',d.get('XmlDoc',''))
        existing={u['name']:u for u in f['units']}; factor='1000' if n=='Volume' else '1'
        for u in expanded(d):
            name=u['SingularName']; aliases={l['Culture']:l['Abbreviations'] for l in u.get('Localization',[])}
            if name in existing:
                for culture,values in aliases.items():existing[name]['aliases'].setdefault(culture,[]).extend(values)
                existing[name]['plural']=u['PluralName'];continue
            to=u['FromUnitToBaseFunc'];fr=u['FromBaseToUnitFunc']
            if factor!='1':to=f'({to}) * {factor}';fr=fr.replace('{x}',f'({{x}} / {factor})')
            v=dict(name=name,id=max([v['id'] for v in f['units']],default=-1)+1, symbol=(aliases.get('en-US') or [name])[0],display=display(name),system=system(name),to=to,fr=fr,aliases=aliases,plural=u['PluralName'])
            f['units'].append(v);existing[name]=v
    # Semantic aliases retain separate quantity types, while sharing definitions.
    for alias,source in {'Enthalpy':'SpecificEnergy','LapseRate':'TemperatureGradient','Dimensionless':'Scalar'}.items():
        f=copy.deepcopy(families[source]);f.update(name=alias,helpers={});families[alias]=f
    extras=json.loads((ROOT/'data/additional-families.json').read_text())
    for f in extras:
        f.setdefault('helpers',{})
        for i,u in enumerate(f['units']):
            u.update(id=i,display=display(u['name']),system=system(u['name']),aliases={'en-US':[u['symbol']]})
            u['to']='{x} * ('+u.pop('factor')+')';u['fr']='{x} / ('+u['to'][7:-1]+')'
        families[f['name']]=f
    # Legacy quantity names are retained, including aliases for established names.
    dimension_aliases={'ActivityConcentration':'Radioactivity','AngularAcceleration':'RotationalAcceleration','AngularVelocity':'RotationalSpeed','ChargeDensity':'ElectricChargeDensity','Conductance':'ElectricConductance','Current':'ElectricCurrent','CurrentDensity':'ElectricCurrentDensity','DataRate':'BitRate','DiffusionCoefficient':'KinematicViscosity','DigitalStorage':'Information','DoseRate':'RadiationEquivalentDoseRate','DynamicPressure':'Pressure','ElectricFieldStrength':'ElectricField','ElectricFluxDensity':'ElectricSurfaceChargeDensity','ElectricalConductivity':'ElectricConductivity','ElectricalResistivity':'ElectricResistivity','FrameRate':'Frequency','FuelEconomy':'FuelEfficiency','HydraulicPermeability':'PorousMediumPermeability','Inductance':'ElectricInductance','MagneticPermeability':'Permeability','MagnetizingFieldStrength':'Magnetization','MassFlowRate':'MassFlow','MolarConcentration':'Molarity','MomentOfInertia':'MassMomentOfInertia','Momentum':'Impulse','RadiationDose':'AbsorbedDoseOfIonizingRadiation','SpecificHeatCapacity':'SpecificEntropy','SurfaceTension':'ForcePerLength','ThermalDiffusivity':'KinematicViscosity','ThermalExpansion':'CoefficientOfThermalExpansion','Time':'Duration','TorquePerAngle':'RotationalStiffness','VaporPressure':'Pressure','Voltage':'ElectricPotential','VolumetricFlowRate':'VolumeFlow','Wavenumber':'ReciprocalLength'}
    for n,source in dimension_aliases.items():
        if n in families and families[n]['dimensions'] is None: families[n]['dimensions']=families[source]['dimensions']
    dims={'Yank':{'L':1,'M':1,'T':-3},'VolumetricFlux':{'L':1,'T':-1},'ActivityConcentration':{'T':-1,'L':-3},'AngularMomentum':{'M':1,'L':2,'T':-1},'ElectricFlux':{'M':1,'L':3,'T':-3,'I':-1},'ExposureRate':{'I':1,'M':-1},'LuminousEfficacy':{'J':1,'M':-1,'L':-2,'T':3},'LuminousEnergy':{'J':1,'T':1},'LuminousExposure':{'J':1,'T':1,'L':-2},'ParticleFluence':{'L':-2},'ParticleFlux':{'L':-2,'T':-1},'PixelDensity':{'L':-1},'PressureGradient':{'M':1,'L':-2,'T':-2},'Radiance':{'M':1,'T':-3},'Snap':{'L':1,'T':-4},'SpecificGravity':{},'VolumetricFlow':{'L':3,'T':-1},'WaveNumber':{'L':-1}}
    for n,d in dims.items():
        if n in families:families[n]['dimensions']=d
    for f in families.values():
        assert f['dimensions'] is not None, 'Missing dimensions: '+f['name']
        for u in f['units']:
            u['rationalTo']=rational(u['to']);u['rationalFrom']=rational(u['fr'])
            u['aliases']={k:list(dict.fromkeys(v)) for k,v in u['aliases'].items()}
    return dict(sorted(families.items()))

def system(name):
    if 'Us' in name or 'US' in name:return 'ImperialUS'
    if 'Uk' in name or 'Imperial' in name:return 'ImperialUK'
    if any(x in name for x in ['Foot','Feet','Inch','Pound','Ounce','Yard','Btu','Gallon','Mile','Fahrenheit','Rankine']):return 'Imperial'
    if any(x in name for x in ['Bit','Byte']):return 'Digital'
    if any(x in name for x in ['Solar','LightYear','Parsec']):return 'Astronomical'
    return 'Scientific'

def main():
    families=make_model()
    write('data/catalog.json',json.dumps(list(families.values()),indent=2,ensure_ascii=False)+'\n')
    for f in families.values():generate_family(f)
    generate_catalog(families)
    print(f'Generated {len(families)} families and {sum(len(f["units"]) for f in families.values())} named units.')

# Generation functions are defined below.
def generate_family(f):
    n=f['name'];c='UnitConverter'+n;e=c+'Unit';v=c+'Value';b=f['base'];us=f['units']
    assert [u['id'] for u in us]==list(range(len(us))), n
    lines=['// <auto-generated />','namespace UnitConverter.'+n,'{','    using System;','    using System.Collections.Generic;','    using System.Globalization;','',f'    public enum {e}','    {']
    lines += [f'        {u["name"]} = {u["id"]},' for u in us]
    lines += ['    }','',f'    public static partial class {c}','    {',f'''        public static double Convert(double value, {e} from, {e} to)
        {{
            Validate(from); Validate(to);
            if (from == to) return value;
            var sourceScale = LinearScale(from);
            var targetScale = LinearScale(to);
            if (!double.IsNaN(sourceScale) && !double.IsNaN(targetScale))
            {{
                var ratio = sourceScale / targetScale;
                if (ratio != 0 && !double.IsInfinity(ratio)) return value * ratio;
                return (value / targetScale) * sourceScale;
            }}
            return From{b}(To{b}(value, from), to);
        }}

        public static decimal ConvertDecimal(decimal value, {e} from, {e} to)
        {{
            Validate(from); Validate(to);
            if (from == to) return value;
            return UnitConverterExact.FromDecimal(value).Apply(GetUnitInfo(from).RationalTo)
                .Apply(GetUnitInfo(to).RationalFrom).ToDecimal();
        }}

        public static UnitConverterConversionResult TryConvert(double value, {e} from, {e} to)
        {{
            if (!UnitConverterText.IsFinite(value)) return UnitConverterConversionResult.Fail("Input must be finite.");
            try
            {{
                var result = Convert(value, from, to);
                return UnitConverterText.IsFinite(result) ? UnitConverterConversionResult.Ok(result)
                    : UnitConverterConversionResult.Fail("The conversion is undefined or exceeds the double range.");
            }}
            catch (ArgumentException error) {{ return UnitConverterConversionResult.Fail(error.Message); }}
            catch (ArithmeticException error) {{ return UnitConverterConversionResult.Fail(error.Message); }}
        }}

        public static bool TryConvert(double value, {e} from, {e} to, out double result)
        {{
            var conversion = TryConvert(value, from, to); result = conversion.Value; return conversion.Success;
        }}

        public static bool TryConvertDecimal(decimal value, {e} from, {e} to, out decimal result)
        {{
            result = 0;
            try {{ result = ConvertDecimal(value, from, to); return true; }}
            catch (ArgumentException) {{ return false; }}
            catch (ArithmeticException) {{ return false; }}
            catch (NotSupportedException) {{ return false; }}
        }}

        private static void Validate({e} unit)
        {{
            if ((uint)unit >= {len(us)}u) throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported {n} unit.");
        }}
''']
    def switch(returntype,method,param,values):
        lines.extend([f'        {"private" if method=="LinearScale" else "public"} static {returntype} {method}({e} {param})','        {',f'            switch ({param})','            {'])
        for u,value in zip(us,values): lines.append(f'                case {e}.{u["name"]}: return {value};')
        lines.extend([f'                default: throw new ArgumentOutOfRangeException(nameof({param}), {param}, "Unsupported {n} unit.");','            }','        }',''])
    for method,param,key in [('To'+b,'from','to'),('From'+b,'to','fr')]:
        lines.extend([f'        public static double {method}(double value, {e} {param})','        {',f'            switch ({param})','            {'])
        for u in us:lines.append(f'                case {e}.{u["name"]}: return {expr(u[key])};')
        lines.extend([f'                default: throw new ArgumentOutOfRangeException(nameof({param}), {param}, "Unsupported {n} unit.");','            }','        }',''])
    def scale(u):
        r=u['rationalTo']
        return repr(float(F(r[1],r[2])))+'d' if r and r[0]==r[3]==0 and r[2] and r[1] else 'double.NaN'
    switch('double','LinearScale','unit',[scale(u) for u in us])
    switch('string','GetSymbol','unit',[cs(u['symbol']) for u in us])
    switch('string','GetDisplayName','unit',[cs(u['display']) for u in us])
    switch('UnitConverterUnitSystem','GetUnitSystem','unit',['UnitConverterUnitSystem.'+u['system'] for u in us])
    lines.append(f'''        public static {e}[] GetUnitsForSystem(UnitConverterUnitSystem system)
        {{
            var units = new List<{e}>();
            for (int i = 0; i < {len(us)}; i++) if (GetUnitSystem(({e})i) == system) units.Add(({e})i);
            return units.ToArray();
        }}

        public static IReadOnlyList<UnitConverterUnitInfo> GetUnits() {{ return Metadata.Units; }}
        public static UnitConverterUnitInfo GetUnitInfo({e} unit) {{ Validate(unit); return Metadata.Units[(int)unit]; }}
        public static string GetSymbol({e} unit, IFormatProvider provider) {{ return GetUnitInfo(unit).GetSymbol(provider); }}

        public static bool TryParseUnit(string text, out {e} unit, IFormatProvider provider = null)
        {{
            int id; bool success = UnitConverterText.TryUnit(text, GetUnits(), provider, out id);
            unit = success ? ({e})id : default({e}); return success;
        }}

        public static {e} ParseUnit(string text, IFormatProvider provider = null)
        {{
            {e} unit;
            if (!TryParseUnit(text, out unit, provider)) throw new FormatException("Unknown or ambiguous {n} unit: " + text);
            return unit;
        }}

        public static bool TryParse(string text, out {v} quantity, IFormatProvider provider = null)
        {{
            double value; int id;
            bool success = UnitConverterText.TryValue(text, GetUnits(), provider, out value, out id);
            quantity = success ? new {v}(value, ({e})id) : default({v}); return success;
        }}

        public static {v} Parse(string text, IFormatProvider provider = null)
        {{
            {v} quantity;
            if (!TryParse(text, out quantity, provider)) throw new FormatException("Expected a finite number and an unambiguous {n} unit.");
            return quantity;
        }}

        public static string Format(double value, {e} unit, string format = "G", IFormatProvider provider = null)
        {{
            return value.ToString(format, provider ?? CultureInfo.CurrentCulture) + " " + GetSymbol(unit, provider);
        }}
''')
    for name,m in f.get('helpers',{}).items():lines.append(f'        public static {m["type"]} {name}({m["args"]}) {{ {m["body"]} }}')
    lines.extend(['','        private static class Metadata','        {','            internal static readonly IReadOnlyList<UnitConverterUnitInfo> Units = Array.AsReadOnly(new UnitConverterUnitInfo[]','            {'])
    for u in us:
        rt=cs(','.join(map(str,u['rationalTo']))) if u['rationalTo'] else 'null';rf=cs(','.join(map(str,u['rationalFrom']))) if u['rationalFrom'] else 'null'
        cultures='new string[] { '+', '.join(cs(k) for k in u['aliases'])+' }'
        aliases='new string[][] { '+', '.join('new string[] { '+', '.join(cs(a) for a in vals)+' }' for vals in u['aliases'].values())+' }'
        lines.append(f'                new UnitConverterUnitInfo({u["id"]}, {cs(u["name"])}, {cs(u["symbol"])}, {cs(u["display"])}, UnitConverterUnitSystem.{u["system"]}, {cs(u.get("plural",u["display"]+"s"))}, {rt}, {rf}, {cultures}, {aliases}),')
    lines.extend(['            });','        }','    }','}',''])
    write(f'src/UnitConverter/{n}/{c}.cs','\n'.join(lines))
    ext=['// <auto-generated />',f'namespace UnitConverter.{n}','{',f'    public static class {c}Extensions','    {']
    for t in ['double','float','decimal','byte','sbyte','short','ushort','int','uint','long','ulong']:
        returntype=t if t in ['double','float','decimal'] else 'double'
        call=f'{c}.ConvertDecimal(value, from, to)' if t=='decimal' else ('(float)' if t=='float' else '')+f'{c}.Convert(value, from, to)'
        ext.append(f'        public static {returntype} Convert(this {t} value, {e} from, {e} to) {{ return {call}; }}')
    ext.append(f'        public static {v} WithUnit(this double value, {e} unit) {{ return new {v}(value, unit); }}')
    ext.extend(['    }','}','']);write(f'src/UnitConverter/{n}/{c}Extensions.cs','\n'.join(ext))
    # Direct methods remain available for every new unit as well.
    old={u['name'] for q in LEGACY['families'] if q['name']==n for u in q['units']}
    added=[u for u in us if u['name'] not in old]
    if added:
        direct=['// <auto-generated />',f'namespace UnitConverter.{n}','{','    using System;',f'    public static class {c}Additional','    {'];names=set()
        for u in added:
            for name,key in [(u['name']+'To'+b,'to'),(b+'To'+u['name'],'fr')]:
                if name in names:continue
                names.add(name);direct.append(f'        public static double {name}(double value) {{ return {expr(u[key])}; }}')
        direct.extend(['    }','}','']);write(f'src/UnitConverter/{n}/{c}Additional.cs','\n'.join(direct))
    generate_value(f)

def generate_value(f):
    n=f['name'];c='UnitConverter'+n;e=c+'Unit';v=c+'Value';b=f['base']
    s=f'''// <auto-generated />
namespace UnitConverter.{n}
{{
    using System;
    using System.Globalization;

    /// <summary>An optional {n} value carrying its unit. Numeric converters remain independent.</summary>
    public readonly struct {v} : IEquatable<{v}>, IComparable<{v}>, IFormattable
    {{
        public double Value {{ get; }}
        public {e} Unit {{ get; }}
        public double BaseValue {{ get {{ return {c}.To{b}(Value, Unit); }} }}

        public {v}(double value, {e} unit)
        {{
            {c}.GetSymbol(unit); Value = value; Unit = unit;
        }}

        public {v} To({e} unit) {{ return new {v}(As(unit), unit); }}
        public double As({e} unit) {{ return {c}.Convert(Value, Unit, unit); }}
        public static {v} FromBase(double value) {{ return new {v}(value, {e}.{b}); }}
        public static {v} Parse(string text, IFormatProvider provider = null) {{ return {c}.Parse(text, provider); }}
        public static bool TryParse(string text, out {v} value, IFormatProvider provider = null) {{ return {c}.TryParse(text, out value, provider); }}
        public override string ToString() {{ return ToString("G", CultureInfo.CurrentCulture); }}
        public string ToString(string format, IFormatProvider provider) {{ return {c}.Format(Value, Unit, format, provider); }}
        public bool Equals({v} other) {{ return BaseValue.Equals(other.BaseValue); }}
        public override bool Equals(object other) {{ return other is {v} && Equals(({v})other); }}
        public override int GetHashCode() {{ return BaseValue.GetHashCode(); }}
        public int CompareTo({v} other) {{ return BaseValue.CompareTo(other.BaseValue); }}
        public bool EqualsWithin({v} other, {v} tolerance)
        {{
            double amount = tolerance.BaseValue;
            if (!UnitConverterText.IsFinite(amount) || amount < 0) throw new ArgumentOutOfRangeException(nameof(tolerance));
            return Math.Abs(BaseValue - other.BaseValue) <= amount;
        }}
        public static bool operator ==({v} left, {v} right) {{ return left.Equals(right); }}
        public static bool operator !=({v} left, {v} right) {{ return !left.Equals(right); }}
        public static bool operator <({v} left, {v} right) {{ return left.CompareTo(right) < 0; }}
        public static bool operator >({v} left, {v} right) {{ return left.CompareTo(right) > 0; }}
        public static bool operator <=({v} left, {v} right) {{ return left.CompareTo(right) <= 0; }}
        public static bool operator >=({v} left, {v} right) {{ return left.CompareTo(right) >= 0; }}
'''
    if n=='Temperature':
        delta='global::UnitConverter.TemperatureDelta.UnitConverterTemperatureDeltaValue'
        s+=f'''        public static {delta} operator -({v} left, {v} right) {{ return {delta}.FromBase(left.BaseValue - right.BaseValue); }}
        public static {v} operator +({v} temperature, {delta} delta) {{ return FromBase(temperature.BaseValue + delta.BaseValue).To(temperature.Unit); }}
        public static {v} operator +({delta} delta, {v} temperature) {{ return temperature + delta; }}
        public static {v} operator -({v} temperature, {delta} delta) {{ return FromBase(temperature.BaseValue - delta.BaseValue).To(temperature.Unit); }}
'''
        s=s.replace(f'EqualsWithin({v} other, {v} tolerance)',f'EqualsWithin({v} other, {delta} tolerance)')
    else:
        s+=f'''        public static {v} operator +({v} left, {v} right) {{ return new {v}(left.Value + right.As(left.Unit), left.Unit); }}
        public static {v} operator -({v} left, {v} right) {{ return new {v}(left.Value - right.As(left.Unit), left.Unit); }}
        public static {v} operator -({v} value) {{ return new {v}(-value.Value, value.Unit); }}
        public static {v} operator *({v} value, double scale) {{ return new {v}(value.Value * scale, value.Unit); }}
        public static {v} operator *(double scale, {v} value) {{ return value * scale; }}
        public static {v} operator /({v} value, double scale) {{ return new {v}(value.Value / scale, value.Unit); }}
        public static double operator /({v} left, {v} right) {{ return left.BaseValue / right.BaseValue; }}
'''
    for left,operator,right,result in RELATIONS:
        if left!=n:continue
        rt=f'global::UnitConverter.{right}.UnitConverter{right}Value';ot=f'global::UnitConverter.{result}.UnitConverter{result}Value'
        # Volume's legacy base is the liter, while dimensional equations use cubic meters.
        lf='left.BaseValue'+(' / 1000d' if left=='Volume' else '');rf='right.BaseValue'+(' / 1000d' if right=='Volume' else '')
        factor=' * 1000d' if result=='Volume' else ''
        s+=f'        public static {ot} operator {operator}({v} left, {rt} right) {{ return {ot}.FromBase((({lf}) {operator} ({rf})){factor}); }}\n'
    s+='    }\n}\n';write(f'src/UnitConverter/{n}/{v}.cs',s)

RELATIONS = [
 ('Length','*','Length','Area'),('Area','*','Length','Volume'),('Length','*','Area','Volume'),
 ('Area','/','Length','Length'),('Volume','/','Area','Length'),('Volume','/','Length','Area'),
 ('Length','/','Time','Speed'),('Length','/','Duration','Speed'),('Length','/','Speed','Time'),
 ('Speed','*','Time','Length'),('Time','*','Speed','Length'),('Speed','*','Duration','Length'),
 ('Speed','/','Time','Acceleration'),('Speed','/','Duration','Acceleration'),
 ('Acceleration','*','Time','Speed'),('Acceleration','*','Duration','Speed'),
 ('Mass','*','Acceleration','Force'),('Acceleration','*','Mass','Force'),('Force','/','Mass','Acceleration'),
 ('Mass','*','Speed','Momentum'),('Force','*','Time','Impulse'),('Force','*','Length','Energy'),
 ('Energy','/','Time','Power'),('Energy','/','Duration','Power'),('Energy','/','Length','Force'),
 ('Power','*','Time','Energy'),('Power','*','Duration','Energy'),('Time','*','Power','Energy'),
 ('Force','/','Area','Pressure'),('Pressure','*','Area','Force'),('Area','*','Pressure','Force'),
 ('Mass','/','Volume','Density'),('Density','*','Volume','Mass'),('Volume','*','Density','Mass'),
 ('Mass','/','Time','MassFlowRate'),('MassFlowRate','*','Time','Mass'),
 ('Volume','/','Time','VolumeFlow'),('VolumeFlow','*','Time','Volume'),
 ('Voltage','*','Current','Power'),('Current','*','Voltage','Power'),('Power','/','Current','Voltage'),
 ('Voltage','/','Current','ElectricResistance'),('ElectricResistance','*','Current','Voltage'),
 ('Current','*','Time','ElectricCharge'),('ElectricCharge','/','Time','Current'),
 ('Energy','/','Mass','SpecificEnergy'),('Energy','/','AmountOfSubstance','MolarEnergy'),
 ('Mass','/','AmountOfSubstance','MolarMass'),('Force','/','Length','ForcePerLength'),
 ('Acceleration','/','Time','Jerk'),('Jerk','/','Time','Snap'),('Length','/','TemperatureDelta','LengthPerTemperature')
]
# Leave semantic ambiguities (for example torque versus work) explicit. No fictitious types.
RELATIONS=[r for r in RELATIONS if r[3]!='LengthPerTemperature']

def generate_catalog(families):
    old=['Length','Area','Volume','Mass','Time','Angle','Speed','Force','Pressure','Energy','Power','Voltage','Current','ElectricResistance','ElectricCharge','Frequency','DigitalStorage','DataRate','Torque','Acceleration','Temperature','FuelEconomy']
    names=old+[n for n in families if n not in old]
    write('src/UnitConverter/Catalog/UnitConverterFamily.cs','// <auto-generated />\nnamespace UnitConverter.Catalog\n{\n    public enum UnitConverterFamily\n    {\n'+''.join(f'        {n} = {i},\n' for i,n in enumerate(names))+'    }\n}\n')
    s='''// <auto-generated />
namespace UnitConverter.Catalog
{
    using System;
    using System.Collections.Generic;

    public static class UnitConverterCatalog
    {
        public static string[] GetFamilyNames() { return new string[] { NAMES }; }
        public static string GetBaseUnitName(string familyName)
        {
            string name;
            if (!TryGetBaseUnitName(familyName, out name)) throw new ArgumentException("Unknown family.", nameof(familyName));
            return name;
        }
        public static bool TryGetBaseUnitName(string familyName, out string baseUnitName)
        {
            switch (familyName)
            {
BASES
                default: baseUnitName = null; return false;
            }
        }
        public static IReadOnlyList<UnitConverterUnitInfo> GetUnits(UnitConverterFamily family)
        {
            switch (family)
            {
UNITS
                default: throw new ArgumentOutOfRangeException(nameof(family));
            }
        }
        public static double Convert(double value, UnitConverterFamily family, int from, int to)
        {
            switch (family)
            {
CONVERTS
                default: throw new ArgumentOutOfRangeException(nameof(family));
            }
        }
        public static decimal ConvertDecimal(decimal value, UnitConverterFamily family, int from, int to)
        {
            switch (family)
            {
DECIMALS
                default: throw new ArgumentOutOfRangeException(nameof(family));
            }
        }
        public static double Convert(double value, string familyName, string from, string to)
        {
            UnitConverterFamily family;
            if (!Enum.TryParse(familyName, false, out family) || !Enum.IsDefined(typeof(UnitConverterFamily), family))
                throw new ArgumentException("Unknown family.", nameof(familyName));
            int source, target;
            if (!UnitConverterText.TryUnit(from, GetUnits(family), System.Globalization.CultureInfo.InvariantCulture, out source)
                || !UnitConverterText.TryUnit(to, GetUnits(family), System.Globalization.CultureInfo.InvariantCulture, out target))
                throw new FormatException("Unknown or ambiguous unit. Use an enum member name to disambiguate.");
            return Convert(value, family, source, target);
        }
    }
}
'''
    s=s.replace('NAMES',', '.join(cs(n) for n in families))
    s=s.replace('BASES','\n'.join(f'                case {cs(n)}: baseUnitName = {cs(f["base"])}; return true;' for n,f in families.items()))
    s=s.replace('UNITS','\n'.join(f'                case UnitConverterFamily.{n}: return global::UnitConverter.{n}.UnitConverter{n}.GetUnits();' for n in families))
    for marker,method in [('CONVERTS','Convert'),('DECIMALS','ConvertDecimal')]:
        s=s.replace(marker,'\n'.join(f'                case UnitConverterFamily.{n}: return global::UnitConverter.{n}.UnitConverter{n}.{method}(value, (global::UnitConverter.{n}.UnitConverter{n}Unit)from, (global::UnitConverter.{n}.UnitConverter{n}Unit)to);' for n in families))
    write('src/UnitConverter/Catalog/UnitConverterCatalog.cs',s)

if __name__=='__main__':main()
