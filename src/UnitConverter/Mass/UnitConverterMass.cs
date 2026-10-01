namespace UnitConverter.Mass
{
    using UnitConverter.Mass.Metric;
    using UnitConverter.Mass.Imperial;
    using UnitConverter.Mass.ImperialUK;
    using UnitConverter.Mass.ImperialUS;
    using UnitConverter.Mass.Troy;
    using UnitConverter.Mass.Engineering;
    using UnitConverter.Mass.Scientific;
    using UnitConverter.Mass.Apothecaries;
    using UnitConverter.Mass.Astronomical;
    using UnitConverter.Mass.Historical;

    public enum UnitConverterMassUnit
    {
        Microgram = 0,
        Milligram = 1,
        Centigram = 2,
        Decigram = 3,
        Gram = 4,
        Decagram = 5,
        Hectogram = 6,
        Kilogram = 7,
        MetricTon = 8,
        Kilotonne = 9,
        Ounce = 10,
        Pound = 11,
        Stone = 12,
        Quarter = 13,
        HundredweightUS = 14,
        HundredweightUK = 15,
        ShortTon = 16,
        LongTon = 17,
        Grain = 18,
        Pennyweight = 19,
        TroyOunce = 20,
        TroyPound = 21,
        Carat = 22,
        Slug = 23,
        AtomicMassUnit = 24,
        Femtogram = 25,
        Picogram = 26,
        Nanogram = 27,
        Megagram = 28,
        Gigagram = 29,
        Teragram = 30,
        Petagram = 31,
        Megatonne = 32,
        Gigatonne = 33,
        Dram = 34,
        ApothecariesScruple = 35,
        ApothecariesDram = 36,
        ApothecariesOunce = 37,
        ApothecariesPound = 38,
        ElectronMass = 39,
        ProtonMass = 40,
        NeutronMass = 41,
        PlanckMass = 42,
        EarthMass = 43,
        JupiterMass = 44,
        SolarMass = 45,
        Shekel = 46,
        Mina = 47,
        Talent = 48,
        Mark = 49,
        Oka = 50,
        Catty = 51,
        Tael = 52,
        Momme = 53,
        PlanckMassGram = 54,
    }

    public static class UnitConverterMass
    {
        public static double Convert(double value, UnitConverterMassUnit from, UnitConverterMassUnit to)
        {
            double baseValue = ToKilogram(value, from);
            return FromKilogram(baseValue, to);
        }

        public static double ToKilogram(double value, UnitConverterMassUnit from)
        {
            switch (from)
            {
                case UnitConverterMassUnit.Microgram:
                    return UnitConverterMetricMass.MicrogramToKilogram(value);
                case UnitConverterMassUnit.Milligram:
                    return UnitConverterMetricMass.MilligramToKilogram(value);
                case UnitConverterMassUnit.Centigram:
                    return UnitConverterMetricMass.CentigramToKilogram(value);
                case UnitConverterMassUnit.Decigram:
                    return UnitConverterMetricMass.DecigramToKilogram(value);
                case UnitConverterMassUnit.Gram:
                    return UnitConverterMetricMass.GramToKilogram(value);
                case UnitConverterMassUnit.Decagram:
                    return UnitConverterMetricMass.DecagramToKilogram(value);
                case UnitConverterMassUnit.Hectogram:
                    return UnitConverterMetricMass.HectogramToKilogram(value);
                case UnitConverterMassUnit.Kilogram:
                    return UnitConverterMetricMass.KilogramToKilogram(value);
                case UnitConverterMassUnit.MetricTon:
                    return UnitConverterMetricMass.MetricTonToKilogram(value);
                case UnitConverterMassUnit.Kilotonne:
                    return UnitConverterMetricMass.KilotonneToKilogram(value);
                case UnitConverterMassUnit.Ounce:
                    return UnitConverterImperialMass.OunceToKilogram(value);
                case UnitConverterMassUnit.Pound:
                    return UnitConverterImperialMass.PoundToKilogram(value);
                case UnitConverterMassUnit.Stone:
                    return UnitConverterImperialUKMass.StoneToKilogram(value);
                case UnitConverterMassUnit.Quarter:
                    return UnitConverterImperialUKMass.QuarterToKilogram(value);
                case UnitConverterMassUnit.HundredweightUS:
                    return UnitConverterImperialUSMass.HundredweightUSToKilogram(value);
                case UnitConverterMassUnit.HundredweightUK:
                    return UnitConverterImperialUKMass.HundredweightUKToKilogram(value);
                case UnitConverterMassUnit.ShortTon:
                    return UnitConverterImperialUSMass.ShortTonToKilogram(value);
                case UnitConverterMassUnit.LongTon:
                    return UnitConverterImperialUKMass.LongTonToKilogram(value);
                case UnitConverterMassUnit.Grain:
                    return UnitConverterTroyMass.GrainToKilogram(value);
                case UnitConverterMassUnit.Pennyweight:
                    return UnitConverterTroyMass.PennyweightToKilogram(value);
                case UnitConverterMassUnit.TroyOunce:
                    return UnitConverterTroyMass.TroyOunceToKilogram(value);
                case UnitConverterMassUnit.TroyPound:
                    return UnitConverterTroyMass.TroyPoundToKilogram(value);
                case UnitConverterMassUnit.Carat:
                    return UnitConverterMetricMass.CaratToKilogram(value);
                case UnitConverterMassUnit.Slug:
                    return UnitConverterEngineeringMass.SlugToKilogram(value);
                case UnitConverterMassUnit.AtomicMassUnit:
                    return UnitConverterScientificMass.AtomicMassUnitToKilogram(value);
                case UnitConverterMassUnit.Femtogram:
                    return UnitConverterMetricMass.FemtogramToKilogram(value);
                case UnitConverterMassUnit.Picogram:
                    return UnitConverterMetricMass.PicogramToKilogram(value);
                case UnitConverterMassUnit.Nanogram:
                    return UnitConverterMetricMass.NanogramToKilogram(value);
                case UnitConverterMassUnit.Megagram:
                    return UnitConverterMetricMass.MegagramToKilogram(value);
                case UnitConverterMassUnit.Gigagram:
                    return UnitConverterMetricMass.GigagramToKilogram(value);
                case UnitConverterMassUnit.Teragram:
                    return UnitConverterMetricMass.TeragramToKilogram(value);
                case UnitConverterMassUnit.Petagram:
                    return UnitConverterMetricMass.PetagramToKilogram(value);
                case UnitConverterMassUnit.Megatonne:
                    return UnitConverterMetricMass.MegatonneToKilogram(value);
                case UnitConverterMassUnit.Gigatonne:
                    return UnitConverterMetricMass.GigatonneToKilogram(value);
                case UnitConverterMassUnit.Dram:
                    return UnitConverterImperialMass.DramToKilogram(value);
                case UnitConverterMassUnit.ApothecariesScruple:
                    return UnitConverterApothecariesMass.ApothecariesScrupleToKilogram(value);
                case UnitConverterMassUnit.ApothecariesDram:
                    return UnitConverterApothecariesMass.ApothecariesDramToKilogram(value);
                case UnitConverterMassUnit.ApothecariesOunce:
                    return UnitConverterApothecariesMass.ApothecariesOunceToKilogram(value);
                case UnitConverterMassUnit.ApothecariesPound:
                    return UnitConverterApothecariesMass.ApothecariesPoundToKilogram(value);
                case UnitConverterMassUnit.ElectronMass:
                    return UnitConverterScientificMass.ElectronMassToKilogram(value);
                case UnitConverterMassUnit.ProtonMass:
                    return UnitConverterScientificMass.ProtonMassToKilogram(value);
                case UnitConverterMassUnit.NeutronMass:
                    return UnitConverterScientificMass.NeutronMassToKilogram(value);
                case UnitConverterMassUnit.PlanckMass:
                    return UnitConverterScientificMass.PlanckMassToKilogram(value);
                case UnitConverterMassUnit.EarthMass:
                    return UnitConverterAstronomicalMass.EarthMassToKilogram(value);
                case UnitConverterMassUnit.JupiterMass:
                    return UnitConverterAstronomicalMass.JupiterMassToKilogram(value);
                case UnitConverterMassUnit.SolarMass:
                    return UnitConverterAstronomicalMass.SolarMassToKilogram(value);
                case UnitConverterMassUnit.Shekel:
                    return UnitConverterHistoricalMass.ShekelToKilogram(value);
                case UnitConverterMassUnit.Mina:
                    return UnitConverterHistoricalMass.MinaToKilogram(value);
                case UnitConverterMassUnit.Talent:
                    return UnitConverterHistoricalMass.TalentToKilogram(value);
                case UnitConverterMassUnit.Mark:
                    return UnitConverterHistoricalMass.MarkToKilogram(value);
                case UnitConverterMassUnit.Oka:
                    return UnitConverterHistoricalMass.OkaToKilogram(value);
                case UnitConverterMassUnit.Catty:
                    return UnitConverterHistoricalMass.CattyToKilogram(value);
                case UnitConverterMassUnit.Tael:
                    return UnitConverterHistoricalMass.TaelToKilogram(value);
                case UnitConverterMassUnit.Momme:
                    return UnitConverterHistoricalMass.MommeToKilogram(value);
                case UnitConverterMassUnit.PlanckMassGram:
                    return UnitConverterScientificMass.PlanckMassGramToKilogram(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported mass unit.");
            }
        }

        public static double FromKilogram(double baseValue, UnitConverterMassUnit to)
        {
            switch (to)
            {
                case UnitConverterMassUnit.Microgram:
                    return UnitConverterMetricMass.KilogramToMicrogram(baseValue);
                case UnitConverterMassUnit.Milligram:
                    return UnitConverterMetricMass.KilogramToMilligram(baseValue);
                case UnitConverterMassUnit.Centigram:
                    return UnitConverterMetricMass.KilogramToCentigram(baseValue);
                case UnitConverterMassUnit.Decigram:
                    return UnitConverterMetricMass.KilogramToDecigram(baseValue);
                case UnitConverterMassUnit.Gram:
                    return UnitConverterMetricMass.KilogramToGram(baseValue);
                case UnitConverterMassUnit.Decagram:
                    return UnitConverterMetricMass.KilogramToDecagram(baseValue);
                case UnitConverterMassUnit.Hectogram:
                    return UnitConverterMetricMass.KilogramToHectogram(baseValue);
                case UnitConverterMassUnit.Kilogram:
                    return UnitConverterMetricMass.KilogramToKilogram(baseValue);
                case UnitConverterMassUnit.MetricTon:
                    return UnitConverterMetricMass.KilogramToMetricTon(baseValue);
                case UnitConverterMassUnit.Kilotonne:
                    return UnitConverterMetricMass.KilogramToKilotonne(baseValue);
                case UnitConverterMassUnit.Ounce:
                    return UnitConverterImperialMass.KilogramToOunce(baseValue);
                case UnitConverterMassUnit.Pound:
                    return UnitConverterImperialMass.KilogramToPound(baseValue);
                case UnitConverterMassUnit.Stone:
                    return UnitConverterImperialUKMass.KilogramToStone(baseValue);
                case UnitConverterMassUnit.Quarter:
                    return UnitConverterImperialUKMass.KilogramToQuarter(baseValue);
                case UnitConverterMassUnit.HundredweightUS:
                    return UnitConverterImperialUSMass.KilogramToHundredweightUS(baseValue);
                case UnitConverterMassUnit.HundredweightUK:
                    return UnitConverterImperialUKMass.KilogramToHundredweightUK(baseValue);
                case UnitConverterMassUnit.ShortTon:
                    return UnitConverterImperialUSMass.KilogramToShortTon(baseValue);
                case UnitConverterMassUnit.LongTon:
                    return UnitConverterImperialUKMass.KilogramToLongTon(baseValue);
                case UnitConverterMassUnit.Grain:
                    return UnitConverterTroyMass.KilogramToGrain(baseValue);
                case UnitConverterMassUnit.Pennyweight:
                    return UnitConverterTroyMass.KilogramToPennyweight(baseValue);
                case UnitConverterMassUnit.TroyOunce:
                    return UnitConverterTroyMass.KilogramToTroyOunce(baseValue);
                case UnitConverterMassUnit.TroyPound:
                    return UnitConverterTroyMass.KilogramToTroyPound(baseValue);
                case UnitConverterMassUnit.Carat:
                    return UnitConverterMetricMass.KilogramToCarat(baseValue);
                case UnitConverterMassUnit.Slug:
                    return UnitConverterEngineeringMass.KilogramToSlug(baseValue);
                case UnitConverterMassUnit.AtomicMassUnit:
                    return UnitConverterScientificMass.KilogramToAtomicMassUnit(baseValue);
                case UnitConverterMassUnit.Femtogram:
                    return UnitConverterMetricMass.KilogramToFemtogram(baseValue);
                case UnitConverterMassUnit.Picogram:
                    return UnitConverterMetricMass.KilogramToPicogram(baseValue);
                case UnitConverterMassUnit.Nanogram:
                    return UnitConverterMetricMass.KilogramToNanogram(baseValue);
                case UnitConverterMassUnit.Megagram:
                    return UnitConverterMetricMass.KilogramToMegagram(baseValue);
                case UnitConverterMassUnit.Gigagram:
                    return UnitConverterMetricMass.KilogramToGigagram(baseValue);
                case UnitConverterMassUnit.Teragram:
                    return UnitConverterMetricMass.KilogramToTeragram(baseValue);
                case UnitConverterMassUnit.Petagram:
                    return UnitConverterMetricMass.KilogramToPetagram(baseValue);
                case UnitConverterMassUnit.Megatonne:
                    return UnitConverterMetricMass.KilogramToMegatonne(baseValue);
                case UnitConverterMassUnit.Gigatonne:
                    return UnitConverterMetricMass.KilogramToGigatonne(baseValue);
                case UnitConverterMassUnit.Dram:
                    return UnitConverterImperialMass.KilogramToDram(baseValue);
                case UnitConverterMassUnit.ApothecariesScruple:
                    return UnitConverterApothecariesMass.KilogramToApothecariesScruple(baseValue);
                case UnitConverterMassUnit.ApothecariesDram:
                    return UnitConverterApothecariesMass.KilogramToApothecariesDram(baseValue);
                case UnitConverterMassUnit.ApothecariesOunce:
                    return UnitConverterApothecariesMass.KilogramToApothecariesOunce(baseValue);
                case UnitConverterMassUnit.ApothecariesPound:
                    return UnitConverterApothecariesMass.KilogramToApothecariesPound(baseValue);
                case UnitConverterMassUnit.ElectronMass:
                    return UnitConverterScientificMass.KilogramToElectronMass(baseValue);
                case UnitConverterMassUnit.ProtonMass:
                    return UnitConverterScientificMass.KilogramToProtonMass(baseValue);
                case UnitConverterMassUnit.NeutronMass:
                    return UnitConverterScientificMass.KilogramToNeutronMass(baseValue);
                case UnitConverterMassUnit.PlanckMass:
                    return UnitConverterScientificMass.KilogramToPlanckMass(baseValue);
                case UnitConverterMassUnit.EarthMass:
                    return UnitConverterAstronomicalMass.KilogramToEarthMass(baseValue);
                case UnitConverterMassUnit.JupiterMass:
                    return UnitConverterAstronomicalMass.KilogramToJupiterMass(baseValue);
                case UnitConverterMassUnit.SolarMass:
                    return UnitConverterAstronomicalMass.KilogramToSolarMass(baseValue);
                case UnitConverterMassUnit.Shekel:
                    return UnitConverterHistoricalMass.KilogramToShekel(baseValue);
                case UnitConverterMassUnit.Mina:
                    return UnitConverterHistoricalMass.KilogramToMina(baseValue);
                case UnitConverterMassUnit.Talent:
                    return UnitConverterHistoricalMass.KilogramToTalent(baseValue);
                case UnitConverterMassUnit.Mark:
                    return UnitConverterHistoricalMass.KilogramToMark(baseValue);
                case UnitConverterMassUnit.Oka:
                    return UnitConverterHistoricalMass.KilogramToOka(baseValue);
                case UnitConverterMassUnit.Catty:
                    return UnitConverterHistoricalMass.KilogramToCatty(baseValue);
                case UnitConverterMassUnit.Tael:
                    return UnitConverterHistoricalMass.KilogramToTael(baseValue);
                case UnitConverterMassUnit.Momme:
                    return UnitConverterHistoricalMass.KilogramToMomme(baseValue);
                case UnitConverterMassUnit.PlanckMassGram:
                    return UnitConverterScientificMass.KilogramToPlanckMassGram(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported mass unit.");
            }
        }

        public static string GetSymbol(UnitConverterMassUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMassUnit.Microgram:
                    return "µg";
                case UnitConverterMassUnit.Milligram:
                    return "mg";
                case UnitConverterMassUnit.Centigram:
                    return "cg";
                case UnitConverterMassUnit.Decigram:
                    return "dg";
                case UnitConverterMassUnit.Gram:
                    return "g";
                case UnitConverterMassUnit.Decagram:
                    return "dag";
                case UnitConverterMassUnit.Hectogram:
                    return "hg";
                case UnitConverterMassUnit.Kilogram:
                    return "kg";
                case UnitConverterMassUnit.MetricTon:
                    return "t";
                case UnitConverterMassUnit.Kilotonne:
                    return "kt";
                case UnitConverterMassUnit.Ounce:
                    return "oz";
                case UnitConverterMassUnit.Pound:
                    return "lb";
                case UnitConverterMassUnit.Stone:
                    return "st";
                case UnitConverterMassUnit.Quarter:
                    return "qr";
                case UnitConverterMassUnit.HundredweightUS:
                    return "cwt US";
                case UnitConverterMassUnit.HundredweightUK:
                    return "cwt UK";
                case UnitConverterMassUnit.ShortTon:
                    return "ton US";
                case UnitConverterMassUnit.LongTon:
                    return "ton UK";
                case UnitConverterMassUnit.Grain:
                    return "gr";
                case UnitConverterMassUnit.Pennyweight:
                    return "dwt";
                case UnitConverterMassUnit.TroyOunce:
                    return "oz t";
                case UnitConverterMassUnit.TroyPound:
                    return "lb t";
                case UnitConverterMassUnit.Carat:
                    return "ct";
                case UnitConverterMassUnit.Slug:
                    return "slug";
                case UnitConverterMassUnit.AtomicMassUnit:
                    return "u";
                case UnitConverterMassUnit.Femtogram:
                    return "fg";
                case UnitConverterMassUnit.Picogram:
                    return "pg";
                case UnitConverterMassUnit.Nanogram:
                    return "ng";
                case UnitConverterMassUnit.Megagram:
                    return "Mg";
                case UnitConverterMassUnit.Gigagram:
                    return "Gg";
                case UnitConverterMassUnit.Teragram:
                    return "Tg";
                case UnitConverterMassUnit.Petagram:
                    return "Pg";
                case UnitConverterMassUnit.Megatonne:
                    return "Mt";
                case UnitConverterMassUnit.Gigatonne:
                    return "Gt";
                case UnitConverterMassUnit.Dram:
                    return "dr";
                case UnitConverterMassUnit.ApothecariesScruple:
                    return "s ap";
                case UnitConverterMassUnit.ApothecariesDram:
                    return "dr ap";
                case UnitConverterMassUnit.ApothecariesOunce:
                    return "oz ap";
                case UnitConverterMassUnit.ApothecariesPound:
                    return "lb ap";
                case UnitConverterMassUnit.ElectronMass:
                    return "me";
                case UnitConverterMassUnit.ProtonMass:
                    return "mp";
                case UnitConverterMassUnit.NeutronMass:
                    return "mn";
                case UnitConverterMassUnit.PlanckMass:
                    return "mP";
                case UnitConverterMassUnit.EarthMass:
                    return "M⊕";
                case UnitConverterMassUnit.JupiterMass:
                    return "MJ";
                case UnitConverterMassUnit.SolarMass:
                    return "M☉";
                case UnitConverterMassUnit.Shekel:
                    return "shekel";
                case UnitConverterMassUnit.Mina:
                    return "mina";
                case UnitConverterMassUnit.Talent:
                    return "talent";
                case UnitConverterMassUnit.Mark:
                    return "mark";
                case UnitConverterMassUnit.Oka:
                    return "oka";
                case UnitConverterMassUnit.Catty:
                    return "catty";
                case UnitConverterMassUnit.Tael:
                    return "tael";
                case UnitConverterMassUnit.Momme:
                    return "momme";
                case UnitConverterMassUnit.PlanckMassGram:
                    return "mP g";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterMassUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMassUnit.Microgram:
                    return "microgram";
                case UnitConverterMassUnit.Milligram:
                    return "milligram";
                case UnitConverterMassUnit.Centigram:
                    return "centigram";
                case UnitConverterMassUnit.Decigram:
                    return "decigram";
                case UnitConverterMassUnit.Gram:
                    return "gram";
                case UnitConverterMassUnit.Decagram:
                    return "decagram";
                case UnitConverterMassUnit.Hectogram:
                    return "hectogram";
                case UnitConverterMassUnit.Kilogram:
                    return "kilogram";
                case UnitConverterMassUnit.MetricTon:
                    return "metric ton";
                case UnitConverterMassUnit.Kilotonne:
                    return "kilotonne";
                case UnitConverterMassUnit.Ounce:
                    return "ounce";
                case UnitConverterMassUnit.Pound:
                    return "pound";
                case UnitConverterMassUnit.Stone:
                    return "stone";
                case UnitConverterMassUnit.Quarter:
                    return "quarter";
                case UnitConverterMassUnit.HundredweightUS:
                    return "US hundredweight";
                case UnitConverterMassUnit.HundredweightUK:
                    return "UK hundredweight";
                case UnitConverterMassUnit.ShortTon:
                    return "short ton";
                case UnitConverterMassUnit.LongTon:
                    return "long ton";
                case UnitConverterMassUnit.Grain:
                    return "grain";
                case UnitConverterMassUnit.Pennyweight:
                    return "pennyweight";
                case UnitConverterMassUnit.TroyOunce:
                    return "troy ounce";
                case UnitConverterMassUnit.TroyPound:
                    return "troy pound";
                case UnitConverterMassUnit.Carat:
                    return "carat";
                case UnitConverterMassUnit.Slug:
                    return "slug";
                case UnitConverterMassUnit.AtomicMassUnit:
                    return "atomic mass unit";
                case UnitConverterMassUnit.Femtogram:
                    return "Femtogram";
                case UnitConverterMassUnit.Picogram:
                    return "Picogram";
                case UnitConverterMassUnit.Nanogram:
                    return "Nanogram";
                case UnitConverterMassUnit.Megagram:
                    return "Megagram";
                case UnitConverterMassUnit.Gigagram:
                    return "Gigagram";
                case UnitConverterMassUnit.Teragram:
                    return "Teragram";
                case UnitConverterMassUnit.Petagram:
                    return "Petagram";
                case UnitConverterMassUnit.Megatonne:
                    return "Megatonne";
                case UnitConverterMassUnit.Gigatonne:
                    return "Gigatonne";
                case UnitConverterMassUnit.Dram:
                    return "Dram";
                case UnitConverterMassUnit.ApothecariesScruple:
                    return "Apothecaries Scruple";
                case UnitConverterMassUnit.ApothecariesDram:
                    return "Apothecaries Dram";
                case UnitConverterMassUnit.ApothecariesOunce:
                    return "Apothecaries Ounce";
                case UnitConverterMassUnit.ApothecariesPound:
                    return "Apothecaries Pound";
                case UnitConverterMassUnit.ElectronMass:
                    return "Electron Mass";
                case UnitConverterMassUnit.ProtonMass:
                    return "Proton Mass";
                case UnitConverterMassUnit.NeutronMass:
                    return "Neutron Mass";
                case UnitConverterMassUnit.PlanckMass:
                    return "Planck Mass";
                case UnitConverterMassUnit.EarthMass:
                    return "Earth Mass";
                case UnitConverterMassUnit.JupiterMass:
                    return "Jupiter Mass";
                case UnitConverterMassUnit.SolarMass:
                    return "Solar Mass";
                case UnitConverterMassUnit.Shekel:
                    return "Shekel";
                case UnitConverterMassUnit.Mina:
                    return "Mina";
                case UnitConverterMassUnit.Talent:
                    return "Talent";
                case UnitConverterMassUnit.Mark:
                    return "Mark";
                case UnitConverterMassUnit.Oka:
                    return "Oka";
                case UnitConverterMassUnit.Catty:
                    return "Catty";
                case UnitConverterMassUnit.Tael:
                    return "Tael";
                case UnitConverterMassUnit.Momme:
                    return "Momme";
                case UnitConverterMassUnit.PlanckMassGram:
                    return "Planck Mass Gram";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterMassUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMassUnit.Microgram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Milligram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Centigram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Decigram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Gram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Decagram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Hectogram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Kilogram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.MetricTon:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Kilotonne:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Ounce:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMassUnit.Pound:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMassUnit.Stone:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterMassUnit.Quarter:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterMassUnit.HundredweightUS:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterMassUnit.HundredweightUK:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterMassUnit.ShortTon:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterMassUnit.LongTon:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterMassUnit.Grain:
                    return UnitConverterUnitSystem.Troy;
                case UnitConverterMassUnit.Pennyweight:
                    return UnitConverterUnitSystem.Troy;
                case UnitConverterMassUnit.TroyOunce:
                    return UnitConverterUnitSystem.Troy;
                case UnitConverterMassUnit.TroyPound:
                    return UnitConverterUnitSystem.Troy;
                case UnitConverterMassUnit.Carat:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Slug:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterMassUnit.AtomicMassUnit:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMassUnit.Femtogram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Picogram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Nanogram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Megagram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Gigagram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Teragram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Petagram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Megatonne:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Gigatonne:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassUnit.Dram:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMassUnit.ApothecariesScruple:
                    return UnitConverterUnitSystem.Apothecaries;
                case UnitConverterMassUnit.ApothecariesDram:
                    return UnitConverterUnitSystem.Apothecaries;
                case UnitConverterMassUnit.ApothecariesOunce:
                    return UnitConverterUnitSystem.Apothecaries;
                case UnitConverterMassUnit.ApothecariesPound:
                    return UnitConverterUnitSystem.Apothecaries;
                case UnitConverterMassUnit.ElectronMass:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMassUnit.ProtonMass:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMassUnit.NeutronMass:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMassUnit.PlanckMass:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMassUnit.EarthMass:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterMassUnit.JupiterMass:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterMassUnit.SolarMass:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterMassUnit.Shekel:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterMassUnit.Mina:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterMassUnit.Talent:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterMassUnit.Mark:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterMassUnit.Oka:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterMassUnit.Catty:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterMassUnit.Tael:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterMassUnit.Momme:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterMassUnit.PlanckMassGram:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterMassUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterMassUnit.Microgram, UnitConverterMassUnit.Milligram, UnitConverterMassUnit.Centigram, UnitConverterMassUnit.Decigram, UnitConverterMassUnit.Gram, UnitConverterMassUnit.Decagram, UnitConverterMassUnit.Hectogram, UnitConverterMassUnit.Kilogram, UnitConverterMassUnit.MetricTon, UnitConverterMassUnit.Kilotonne, UnitConverterMassUnit.Carat, UnitConverterMassUnit.Femtogram, UnitConverterMassUnit.Picogram, UnitConverterMassUnit.Nanogram, UnitConverterMassUnit.Megagram, UnitConverterMassUnit.Gigagram, UnitConverterMassUnit.Teragram, UnitConverterMassUnit.Petagram, UnitConverterMassUnit.Megatonne, UnitConverterMassUnit.Gigatonne };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterMassUnit.Ounce, UnitConverterMassUnit.Pound, UnitConverterMassUnit.Dram };
                case UnitConverterUnitSystem.ImperialUK:
                    return new[] { UnitConverterMassUnit.Stone, UnitConverterMassUnit.Quarter, UnitConverterMassUnit.HundredweightUK, UnitConverterMassUnit.LongTon };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterMassUnit.HundredweightUS, UnitConverterMassUnit.ShortTon };
                case UnitConverterUnitSystem.Troy:
                    return new[] { UnitConverterMassUnit.Grain, UnitConverterMassUnit.Pennyweight, UnitConverterMassUnit.TroyOunce, UnitConverterMassUnit.TroyPound };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterMassUnit.Slug };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterMassUnit.AtomicMassUnit, UnitConverterMassUnit.ElectronMass, UnitConverterMassUnit.ProtonMass, UnitConverterMassUnit.NeutronMass, UnitConverterMassUnit.PlanckMass, UnitConverterMassUnit.PlanckMassGram };
                case UnitConverterUnitSystem.Apothecaries:
                    return new[] { UnitConverterMassUnit.ApothecariesScruple, UnitConverterMassUnit.ApothecariesDram, UnitConverterMassUnit.ApothecariesOunce, UnitConverterMassUnit.ApothecariesPound };
                case UnitConverterUnitSystem.Astronomical:
                    return new[] { UnitConverterMassUnit.EarthMass, UnitConverterMassUnit.JupiterMass, UnitConverterMassUnit.SolarMass };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterMassUnit.Shekel, UnitConverterMassUnit.Mina, UnitConverterMassUnit.Talent, UnitConverterMassUnit.Mark, UnitConverterMassUnit.Oka, UnitConverterMassUnit.Catty, UnitConverterMassUnit.Tael, UnitConverterMassUnit.Momme };
                default:
                    return new[] { UnitConverterMassUnit.Microgram, UnitConverterMassUnit.Milligram, UnitConverterMassUnit.Centigram, UnitConverterMassUnit.Decigram, UnitConverterMassUnit.Gram, UnitConverterMassUnit.Decagram, UnitConverterMassUnit.Hectogram, UnitConverterMassUnit.Kilogram, UnitConverterMassUnit.MetricTon, UnitConverterMassUnit.Kilotonne, UnitConverterMassUnit.Ounce, UnitConverterMassUnit.Pound, UnitConverterMassUnit.Stone, UnitConverterMassUnit.Quarter, UnitConverterMassUnit.HundredweightUS, UnitConverterMassUnit.HundredweightUK, UnitConverterMassUnit.ShortTon, UnitConverterMassUnit.LongTon, UnitConverterMassUnit.Grain, UnitConverterMassUnit.Pennyweight, UnitConverterMassUnit.TroyOunce, UnitConverterMassUnit.TroyPound, UnitConverterMassUnit.Carat, UnitConverterMassUnit.Slug, UnitConverterMassUnit.AtomicMassUnit, UnitConverterMassUnit.Femtogram, UnitConverterMassUnit.Picogram, UnitConverterMassUnit.Nanogram, UnitConverterMassUnit.Megagram, UnitConverterMassUnit.Gigagram, UnitConverterMassUnit.Teragram, UnitConverterMassUnit.Petagram, UnitConverterMassUnit.Megatonne, UnitConverterMassUnit.Gigatonne, UnitConverterMassUnit.Dram, UnitConverterMassUnit.ApothecariesScruple, UnitConverterMassUnit.ApothecariesDram, UnitConverterMassUnit.ApothecariesOunce, UnitConverterMassUnit.ApothecariesPound, UnitConverterMassUnit.ElectronMass, UnitConverterMassUnit.ProtonMass, UnitConverterMassUnit.NeutronMass, UnitConverterMassUnit.PlanckMass, UnitConverterMassUnit.EarthMass, UnitConverterMassUnit.JupiterMass, UnitConverterMassUnit.SolarMass, UnitConverterMassUnit.Shekel, UnitConverterMassUnit.Mina, UnitConverterMassUnit.Talent, UnitConverterMassUnit.Mark, UnitConverterMassUnit.Oka, UnitConverterMassUnit.Catty, UnitConverterMassUnit.Tael, UnitConverterMassUnit.Momme, UnitConverterMassUnit.PlanckMassGram };
            }
        }
    }
}
