"""One-time baseline capture. Run only against the preview.1 source tree."""
import json
import re
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
SRC = ROOT / 'src/UnitConverter'

def methods(text):
    result = {}
    for m in re.finditer(r'public static ([\w\[\]]+) (\w+)\(([^)]*)\)\s*\{', text):
        start = m.end(); depth = 1; end = start
        while depth:
            depth += (text[end] == '{') - (text[end] == '}'); end += 1
        result[m[2]] = dict(type=m[1], args=m[3], body=text[start:end-1].strip())
    return result

def main():
    functions = {}
    signatures = []
    for p in SRC.rglob('*.cs'):
        s = p.read_text(encoding='utf-8-sig')
        ns = re.search(r'namespace ([\w.]+)', s)[1]
        cls = re.search(r'public (?:static |readonly )?(?:class|struct) (\w+)', s)
        if not cls: continue
        for m in re.finditer(r'public static ([\w\[\]]+) (\w+)\(([^)]*)\)',s):
            signatures.append([ns+'.'+cls[1],m[1],m[2],m[3]])
        for name, m in methods(s).items():
            if m['type']=='double' and re.fullmatch(r'double \w+',m['args']):
                assert re.fullmatch(r'return [^;]+;',m['body']), (p,name)
                arg=m['args'].split()[1]
                expression=re.sub(r'\b'+arg+r'\b','{x}',m['body'][7:-1])
                functions[cls[1]+'.'+name] = dict(expression=expression, qualified=ns+'.'+cls[1]+'.'+name)
    families=[]
    for p in sorted(SRC.glob('*/UnitConverter*.cs')):
        s=p.read_text(); match=re.search(r'public enum UnitConverter(\w+)Unit\s*\{([^}]+)',s)
        if not match: continue
        name=match[1]; mm=methods(s); base=next(n[2:] for n in mm if n.startswith('To') and mm[n]['args'].endswith('Unit from'))
        def cases(method):
            return dict(re.findall(r'case UnitConverter\w+Unit\.(\w+):\s*return ([^;]+);', mm[method]['body']))
        to,fr,sy,dn,us=[cases(n) for n in ['To'+base,'From'+base,'GetSymbol','GetDisplayName','GetUnitSystem']]
        units=[]
        for un, id in re.findall(r'(\w+)\s*=\s*(\d+)', match[2]):
            def expr(call):
                func=call.split('(')[0]
                if '.' not in func: func='UnitConverter'+name+'.'+func
                return functions[func]['expression']
            units.append(dict(name=un,id=int(id),symbol=json.loads(sy[un]),display=json.loads(dn[un]),system=us[un].split('.')[-1],to=expr(to[un]),fr=expr(fr[un])))
        helpers={n:m for n,m in mm.items() if m['type']=='double' and re.fullmatch(r'double \w+',m['args'])}
        families.append(dict(name=name,base=base,units=units,helpers=helpers))
    target=ROOT/'data/legacy-api.json'
    assert not target.exists(), 'Do not replace the compatibility baseline.'
    target.write_text(json.dumps(dict(commit='fb82ad485696aafb1d16138b21d336605a9fcbf1',families=families,signatures=signatures),indent=2,ensure_ascii=False)+'\n')
    print(f'Captured {len(families)} families, {sum(len(f["units"]) for f in families)} units, {len(signatures)} signatures')

if __name__=='__main__': main()
