namespace UnitTools.Mass
{
    using UnitTools.Mass.Metric;
    using UnitTools.Mass.Imperial;
    using UnitTools.Mass.ImperialUK;
    using UnitTools.Mass.ImperialUS;
    using UnitTools.Mass.Troy;
    using UnitTools.Mass.Engineering;
    using UnitTools.Mass.Scientific;
    using UnitTools.Mass.Apothecaries;
    using UnitTools.Mass.Astronomical;
    using UnitTools.Mass.Historical;

    public enum UnitToolsMassUnit
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

    public static class UnitToolsMass
    {
        public static double Convert(double value, UnitToolsMassUnit from, UnitToolsMassUnit to)
        {
            double baseValue = ToKilogram(value, from);
            return FromKilogram(baseValue, to);
        }

        public static double ToKilogram(double value, UnitToolsMassUnit from)
        {
            switch (from)
            {
                case UnitToolsMassUnit.Microgram:
                    return UnitToolsMetricMass.MicrogramToKilogram(value);
                case UnitToolsMassUnit.Milligram:
                    return UnitToolsMetricMass.MilligramToKilogram(value);
                case UnitToolsMassUnit.Centigram:
                    return UnitToolsMetricMass.CentigramToKilogram(value);
                case UnitToolsMassUnit.Decigram:
                    return UnitToolsMetricMass.DecigramToKilogram(value);
                case UnitToolsMassUnit.Gram:
                    return UnitToolsMetricMass.GramToKilogram(value);
                case UnitToolsMassUnit.Decagram:
                    return UnitToolsMetricMass.DecagramToKilogram(value);
                case UnitToolsMassUnit.Hectogram:
                    return UnitToolsMetricMass.HectogramToKilogram(value);
                case UnitToolsMassUnit.Kilogram:
                    return UnitToolsMetricMass.KilogramToKilogram(value);
                case UnitToolsMassUnit.MetricTon:
                    return UnitToolsMetricMass.MetricTonToKilogram(value);
                case UnitToolsMassUnit.Kilotonne:
                    return UnitToolsMetricMass.KilotonneToKilogram(value);
                case UnitToolsMassUnit.Ounce:
                    return UnitToolsImperialMass.OunceToKilogram(value);
                case UnitToolsMassUnit.Pound:
                    return UnitToolsImperialMass.PoundToKilogram(value);
                case UnitToolsMassUnit.Stone:
                    return UnitToolsImperialUKMass.StoneToKilogram(value);
                case UnitToolsMassUnit.Quarter:
                    return UnitToolsImperialUKMass.QuarterToKilogram(value);
                case UnitToolsMassUnit.HundredweightUS:
                    return UnitToolsImperialUSMass.HundredweightUSToKilogram(value);
                case UnitToolsMassUnit.HundredweightUK:
                    return UnitToolsImperialUKMass.HundredweightUKToKilogram(value);
                case UnitToolsMassUnit.ShortTon:
                    return UnitToolsImperialUSMass.ShortTonToKilogram(value);
                case UnitToolsMassUnit.LongTon:
                    return UnitToolsImperialUKMass.LongTonToKilogram(value);
                case UnitToolsMassUnit.Grain:
                    return UnitToolsTroyMass.GrainToKilogram(value);
                case UnitToolsMassUnit.Pennyweight:
                    return UnitToolsTroyMass.PennyweightToKilogram(value);
                case UnitToolsMassUnit.TroyOunce:
                    return UnitToolsTroyMass.TroyOunceToKilogram(value);
                case UnitToolsMassUnit.TroyPound:
                    return UnitToolsTroyMass.TroyPoundToKilogram(value);
                case UnitToolsMassUnit.Carat:
                    return UnitToolsMetricMass.CaratToKilogram(value);
                case UnitToolsMassUnit.Slug:
                    return UnitToolsEngineeringMass.SlugToKilogram(value);
                case UnitToolsMassUnit.AtomicMassUnit:
                    return UnitToolsScientificMass.AtomicMassUnitToKilogram(value);
                case UnitToolsMassUnit.Femtogram:
                    return UnitToolsMetricMass.FemtogramToKilogram(value);
                case UnitToolsMassUnit.Picogram:
                    return UnitToolsMetricMass.PicogramToKilogram(value);
                case UnitToolsMassUnit.Nanogram:
                    return UnitToolsMetricMass.NanogramToKilogram(value);
                case UnitToolsMassUnit.Megagram:
                    return UnitToolsMetricMass.MegagramToKilogram(value);
                case UnitToolsMassUnit.Gigagram:
                    return UnitToolsMetricMass.GigagramToKilogram(value);
                case UnitToolsMassUnit.Teragram:
                    return UnitToolsMetricMass.TeragramToKilogram(value);
                case UnitToolsMassUnit.Petagram:
                    return UnitToolsMetricMass.PetagramToKilogram(value);
                case UnitToolsMassUnit.Megatonne:
                    return UnitToolsMetricMass.MegatonneToKilogram(value);
                case UnitToolsMassUnit.Gigatonne:
                    return UnitToolsMetricMass.GigatonneToKilogram(value);
                case UnitToolsMassUnit.Dram:
                    return UnitToolsImperialMass.DramToKilogram(value);
                case UnitToolsMassUnit.ApothecariesScruple:
                    return UnitToolsApothecariesMass.ApothecariesScrupleToKilogram(value);
                case UnitToolsMassUnit.ApothecariesDram:
                    return UnitToolsApothecariesMass.ApothecariesDramToKilogram(value);
                case UnitToolsMassUnit.ApothecariesOunce:
                    return UnitToolsApothecariesMass.ApothecariesOunceToKilogram(value);
                case UnitToolsMassUnit.ApothecariesPound:
                    return UnitToolsApothecariesMass.ApothecariesPoundToKilogram(value);
                case UnitToolsMassUnit.ElectronMass:
                    return UnitToolsScientificMass.ElectronMassToKilogram(value);
                case UnitToolsMassUnit.ProtonMass:
                    return UnitToolsScientificMass.ProtonMassToKilogram(value);
                case UnitToolsMassUnit.NeutronMass:
                    return UnitToolsScientificMass.NeutronMassToKilogram(value);
                case UnitToolsMassUnit.PlanckMass:
                    return UnitToolsScientificMass.PlanckMassToKilogram(value);
                case UnitToolsMassUnit.EarthMass:
                    return UnitToolsAstronomicalMass.EarthMassToKilogram(value);
                case UnitToolsMassUnit.JupiterMass:
                    return UnitToolsAstronomicalMass.JupiterMassToKilogram(value);
                case UnitToolsMassUnit.SolarMass:
                    return UnitToolsAstronomicalMass.SolarMassToKilogram(value);
                case UnitToolsMassUnit.Shekel:
                    return UnitToolsHistoricalMass.ShekelToKilogram(value);
                case UnitToolsMassUnit.Mina:
                    return UnitToolsHistoricalMass.MinaToKilogram(value);
                case UnitToolsMassUnit.Talent:
                    return UnitToolsHistoricalMass.TalentToKilogram(value);
                case UnitToolsMassUnit.Mark:
                    return UnitToolsHistoricalMass.MarkToKilogram(value);
                case UnitToolsMassUnit.Oka:
                    return UnitToolsHistoricalMass.OkaToKilogram(value);
                case UnitToolsMassUnit.Catty:
                    return UnitToolsHistoricalMass.CattyToKilogram(value);
                case UnitToolsMassUnit.Tael:
                    return UnitToolsHistoricalMass.TaelToKilogram(value);
                case UnitToolsMassUnit.Momme:
                    return UnitToolsHistoricalMass.MommeToKilogram(value);
                case UnitToolsMassUnit.PlanckMassGram:
                    return UnitToolsScientificMass.PlanckMassGramToKilogram(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported mass unit.");
            }
        }

        public static double FromKilogram(double baseValue, UnitToolsMassUnit to)
        {
            switch (to)
            {
                case UnitToolsMassUnit.Microgram:
                    return UnitToolsMetricMass.KilogramToMicrogram(baseValue);
                case UnitToolsMassUnit.Milligram:
                    return UnitToolsMetricMass.KilogramToMilligram(baseValue);
                case UnitToolsMassUnit.Centigram:
                    return UnitToolsMetricMass.KilogramToCentigram(baseValue);
                case UnitToolsMassUnit.Decigram:
                    return UnitToolsMetricMass.KilogramToDecigram(baseValue);
                case UnitToolsMassUnit.Gram:
                    return UnitToolsMetricMass.KilogramToGram(baseValue);
                case UnitToolsMassUnit.Decagram:
                    return UnitToolsMetricMass.KilogramToDecagram(baseValue);
                case UnitToolsMassUnit.Hectogram:
                    return UnitToolsMetricMass.KilogramToHectogram(baseValue);
                case UnitToolsMassUnit.Kilogram:
                    return UnitToolsMetricMass.KilogramToKilogram(baseValue);
                case UnitToolsMassUnit.MetricTon:
                    return UnitToolsMetricMass.KilogramToMetricTon(baseValue);
                case UnitToolsMassUnit.Kilotonne:
                    return UnitToolsMetricMass.KilogramToKilotonne(baseValue);
                case UnitToolsMassUnit.Ounce:
                    return UnitToolsImperialMass.KilogramToOunce(baseValue);
                case UnitToolsMassUnit.Pound:
                    return UnitToolsImperialMass.KilogramToPound(baseValue);
                case UnitToolsMassUnit.Stone:
                    return UnitToolsImperialUKMass.KilogramToStone(baseValue);
                case UnitToolsMassUnit.Quarter:
                    return UnitToolsImperialUKMass.KilogramToQuarter(baseValue);
                case UnitToolsMassUnit.HundredweightUS:
                    return UnitToolsImperialUSMass.KilogramToHundredweightUS(baseValue);
                case UnitToolsMassUnit.HundredweightUK:
                    return UnitToolsImperialUKMass.KilogramToHundredweightUK(baseValue);
                case UnitToolsMassUnit.ShortTon:
                    return UnitToolsImperialUSMass.KilogramToShortTon(baseValue);
                case UnitToolsMassUnit.LongTon:
                    return UnitToolsImperialUKMass.KilogramToLongTon(baseValue);
                case UnitToolsMassUnit.Grain:
                    return UnitToolsTroyMass.KilogramToGrain(baseValue);
                case UnitToolsMassUnit.Pennyweight:
                    return UnitToolsTroyMass.KilogramToPennyweight(baseValue);
                case UnitToolsMassUnit.TroyOunce:
                    return UnitToolsTroyMass.KilogramToTroyOunce(baseValue);
                case UnitToolsMassUnit.TroyPound:
                    return UnitToolsTroyMass.KilogramToTroyPound(baseValue);
                case UnitToolsMassUnit.Carat:
                    return UnitToolsMetricMass.KilogramToCarat(baseValue);
                case UnitToolsMassUnit.Slug:
                    return UnitToolsEngineeringMass.KilogramToSlug(baseValue);
                case UnitToolsMassUnit.AtomicMassUnit:
                    return UnitToolsScientificMass.KilogramToAtomicMassUnit(baseValue);
                case UnitToolsMassUnit.Femtogram:
                    return UnitToolsMetricMass.KilogramToFemtogram(baseValue);
                case UnitToolsMassUnit.Picogram:
                    return UnitToolsMetricMass.KilogramToPicogram(baseValue);
                case UnitToolsMassUnit.Nanogram:
                    return UnitToolsMetricMass.KilogramToNanogram(baseValue);
                case UnitToolsMassUnit.Megagram:
                    return UnitToolsMetricMass.KilogramToMegagram(baseValue);
                case UnitToolsMassUnit.Gigagram:
                    return UnitToolsMetricMass.KilogramToGigagram(baseValue);
                case UnitToolsMassUnit.Teragram:
                    return UnitToolsMetricMass.KilogramToTeragram(baseValue);
                case UnitToolsMassUnit.Petagram:
                    return UnitToolsMetricMass.KilogramToPetagram(baseValue);
                case UnitToolsMassUnit.Megatonne:
                    return UnitToolsMetricMass.KilogramToMegatonne(baseValue);
                case UnitToolsMassUnit.Gigatonne:
                    return UnitToolsMetricMass.KilogramToGigatonne(baseValue);
                case UnitToolsMassUnit.Dram:
                    return UnitToolsImperialMass.KilogramToDram(baseValue);
                case UnitToolsMassUnit.ApothecariesScruple:
                    return UnitToolsApothecariesMass.KilogramToApothecariesScruple(baseValue);
                case UnitToolsMassUnit.ApothecariesDram:
                    return UnitToolsApothecariesMass.KilogramToApothecariesDram(baseValue);
                case UnitToolsMassUnit.ApothecariesOunce:
                    return UnitToolsApothecariesMass.KilogramToApothecariesOunce(baseValue);
                case UnitToolsMassUnit.ApothecariesPound:
                    return UnitToolsApothecariesMass.KilogramToApothecariesPound(baseValue);
                case UnitToolsMassUnit.ElectronMass:
                    return UnitToolsScientificMass.KilogramToElectronMass(baseValue);
                case UnitToolsMassUnit.ProtonMass:
                    return UnitToolsScientificMass.KilogramToProtonMass(baseValue);
                case UnitToolsMassUnit.NeutronMass:
                    return UnitToolsScientificMass.KilogramToNeutronMass(baseValue);
                case UnitToolsMassUnit.PlanckMass:
                    return UnitToolsScientificMass.KilogramToPlanckMass(baseValue);
                case UnitToolsMassUnit.EarthMass:
                    return UnitToolsAstronomicalMass.KilogramToEarthMass(baseValue);
                case UnitToolsMassUnit.JupiterMass:
                    return UnitToolsAstronomicalMass.KilogramToJupiterMass(baseValue);
                case UnitToolsMassUnit.SolarMass:
                    return UnitToolsAstronomicalMass.KilogramToSolarMass(baseValue);
                case UnitToolsMassUnit.Shekel:
                    return UnitToolsHistoricalMass.KilogramToShekel(baseValue);
                case UnitToolsMassUnit.Mina:
                    return UnitToolsHistoricalMass.KilogramToMina(baseValue);
                case UnitToolsMassUnit.Talent:
                    return UnitToolsHistoricalMass.KilogramToTalent(baseValue);
                case UnitToolsMassUnit.Mark:
                    return UnitToolsHistoricalMass.KilogramToMark(baseValue);
                case UnitToolsMassUnit.Oka:
                    return UnitToolsHistoricalMass.KilogramToOka(baseValue);
                case UnitToolsMassUnit.Catty:
                    return UnitToolsHistoricalMass.KilogramToCatty(baseValue);
                case UnitToolsMassUnit.Tael:
                    return UnitToolsHistoricalMass.KilogramToTael(baseValue);
                case UnitToolsMassUnit.Momme:
                    return UnitToolsHistoricalMass.KilogramToMomme(baseValue);
                case UnitToolsMassUnit.PlanckMassGram:
                    return UnitToolsScientificMass.KilogramToPlanckMassGram(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported mass unit.");
            }
        }

        public static string GetSymbol(UnitToolsMassUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMassUnit.Microgram:
                    return "µg";
                case UnitToolsMassUnit.Milligram:
                    return "mg";
                case UnitToolsMassUnit.Centigram:
                    return "cg";
                case UnitToolsMassUnit.Decigram:
                    return "dg";
                case UnitToolsMassUnit.Gram:
                    return "g";
                case UnitToolsMassUnit.Decagram:
                    return "dag";
                case UnitToolsMassUnit.Hectogram:
                    return "hg";
                case UnitToolsMassUnit.Kilogram:
                    return "kg";
                case UnitToolsMassUnit.MetricTon:
                    return "t";
                case UnitToolsMassUnit.Kilotonne:
                    return "kt";
                case UnitToolsMassUnit.Ounce:
                    return "oz";
                case UnitToolsMassUnit.Pound:
                    return "lb";
                case UnitToolsMassUnit.Stone:
                    return "st";
                case UnitToolsMassUnit.Quarter:
                    return "qr";
                case UnitToolsMassUnit.HundredweightUS:
                    return "cwt US";
                case UnitToolsMassUnit.HundredweightUK:
                    return "cwt UK";
                case UnitToolsMassUnit.ShortTon:
                    return "ton US";
                case UnitToolsMassUnit.LongTon:
                    return "ton UK";
                case UnitToolsMassUnit.Grain:
                    return "gr";
                case UnitToolsMassUnit.Pennyweight:
                    return "dwt";
                case UnitToolsMassUnit.TroyOunce:
                    return "oz t";
                case UnitToolsMassUnit.TroyPound:
                    return "lb t";
                case UnitToolsMassUnit.Carat:
                    return "ct";
                case UnitToolsMassUnit.Slug:
                    return "slug";
                case UnitToolsMassUnit.AtomicMassUnit:
                    return "u";
                case UnitToolsMassUnit.Femtogram:
                    return "fg";
                case UnitToolsMassUnit.Picogram:
                    return "pg";
                case UnitToolsMassUnit.Nanogram:
                    return "ng";
                case UnitToolsMassUnit.Megagram:
                    return "Mg";
                case UnitToolsMassUnit.Gigagram:
                    return "Gg";
                case UnitToolsMassUnit.Teragram:
                    return "Tg";
                case UnitToolsMassUnit.Petagram:
                    return "Pg";
                case UnitToolsMassUnit.Megatonne:
                    return "Mt";
                case UnitToolsMassUnit.Gigatonne:
                    return "Gt";
                case UnitToolsMassUnit.Dram:
                    return "dr";
                case UnitToolsMassUnit.ApothecariesScruple:
                    return "s ap";
                case UnitToolsMassUnit.ApothecariesDram:
                    return "dr ap";
                case UnitToolsMassUnit.ApothecariesOunce:
                    return "oz ap";
                case UnitToolsMassUnit.ApothecariesPound:
                    return "lb ap";
                case UnitToolsMassUnit.ElectronMass:
                    return "me";
                case UnitToolsMassUnit.ProtonMass:
                    return "mp";
                case UnitToolsMassUnit.NeutronMass:
                    return "mn";
                case UnitToolsMassUnit.PlanckMass:
                    return "mP";
                case UnitToolsMassUnit.EarthMass:
                    return "M⊕";
                case UnitToolsMassUnit.JupiterMass:
                    return "MJ";
                case UnitToolsMassUnit.SolarMass:
                    return "M☉";
                case UnitToolsMassUnit.Shekel:
                    return "shekel";
                case UnitToolsMassUnit.Mina:
                    return "mina";
                case UnitToolsMassUnit.Talent:
                    return "talent";
                case UnitToolsMassUnit.Mark:
                    return "mark";
                case UnitToolsMassUnit.Oka:
                    return "oka";
                case UnitToolsMassUnit.Catty:
                    return "catty";
                case UnitToolsMassUnit.Tael:
                    return "tael";
                case UnitToolsMassUnit.Momme:
                    return "momme";
                case UnitToolsMassUnit.PlanckMassGram:
                    return "mP g";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsMassUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMassUnit.Microgram:
                    return "microgram";
                case UnitToolsMassUnit.Milligram:
                    return "milligram";
                case UnitToolsMassUnit.Centigram:
                    return "centigram";
                case UnitToolsMassUnit.Decigram:
                    return "decigram";
                case UnitToolsMassUnit.Gram:
                    return "gram";
                case UnitToolsMassUnit.Decagram:
                    return "decagram";
                case UnitToolsMassUnit.Hectogram:
                    return "hectogram";
                case UnitToolsMassUnit.Kilogram:
                    return "kilogram";
                case UnitToolsMassUnit.MetricTon:
                    return "metric ton";
                case UnitToolsMassUnit.Kilotonne:
                    return "kilotonne";
                case UnitToolsMassUnit.Ounce:
                    return "ounce";
                case UnitToolsMassUnit.Pound:
                    return "pound";
                case UnitToolsMassUnit.Stone:
                    return "stone";
                case UnitToolsMassUnit.Quarter:
                    return "quarter";
                case UnitToolsMassUnit.HundredweightUS:
                    return "US hundredweight";
                case UnitToolsMassUnit.HundredweightUK:
                    return "UK hundredweight";
                case UnitToolsMassUnit.ShortTon:
                    return "short ton";
                case UnitToolsMassUnit.LongTon:
                    return "long ton";
                case UnitToolsMassUnit.Grain:
                    return "grain";
                case UnitToolsMassUnit.Pennyweight:
                    return "pennyweight";
                case UnitToolsMassUnit.TroyOunce:
                    return "troy ounce";
                case UnitToolsMassUnit.TroyPound:
                    return "troy pound";
                case UnitToolsMassUnit.Carat:
                    return "carat";
                case UnitToolsMassUnit.Slug:
                    return "slug";
                case UnitToolsMassUnit.AtomicMassUnit:
                    return "atomic mass unit";
                case UnitToolsMassUnit.Femtogram:
                    return "Femtogram";
                case UnitToolsMassUnit.Picogram:
                    return "Picogram";
                case UnitToolsMassUnit.Nanogram:
                    return "Nanogram";
                case UnitToolsMassUnit.Megagram:
                    return "Megagram";
                case UnitToolsMassUnit.Gigagram:
                    return "Gigagram";
                case UnitToolsMassUnit.Teragram:
                    return "Teragram";
                case UnitToolsMassUnit.Petagram:
                    return "Petagram";
                case UnitToolsMassUnit.Megatonne:
                    return "Megatonne";
                case UnitToolsMassUnit.Gigatonne:
                    return "Gigatonne";
                case UnitToolsMassUnit.Dram:
                    return "Dram";
                case UnitToolsMassUnit.ApothecariesScruple:
                    return "Apothecaries Scruple";
                case UnitToolsMassUnit.ApothecariesDram:
                    return "Apothecaries Dram";
                case UnitToolsMassUnit.ApothecariesOunce:
                    return "Apothecaries Ounce";
                case UnitToolsMassUnit.ApothecariesPound:
                    return "Apothecaries Pound";
                case UnitToolsMassUnit.ElectronMass:
                    return "Electron Mass";
                case UnitToolsMassUnit.ProtonMass:
                    return "Proton Mass";
                case UnitToolsMassUnit.NeutronMass:
                    return "Neutron Mass";
                case UnitToolsMassUnit.PlanckMass:
                    return "Planck Mass";
                case UnitToolsMassUnit.EarthMass:
                    return "Earth Mass";
                case UnitToolsMassUnit.JupiterMass:
                    return "Jupiter Mass";
                case UnitToolsMassUnit.SolarMass:
                    return "Solar Mass";
                case UnitToolsMassUnit.Shekel:
                    return "Shekel";
                case UnitToolsMassUnit.Mina:
                    return "Mina";
                case UnitToolsMassUnit.Talent:
                    return "Talent";
                case UnitToolsMassUnit.Mark:
                    return "Mark";
                case UnitToolsMassUnit.Oka:
                    return "Oka";
                case UnitToolsMassUnit.Catty:
                    return "Catty";
                case UnitToolsMassUnit.Tael:
                    return "Tael";
                case UnitToolsMassUnit.Momme:
                    return "Momme";
                case UnitToolsMassUnit.PlanckMassGram:
                    return "Planck Mass Gram";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsMassUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMassUnit.Microgram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Milligram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Centigram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Decigram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Gram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Decagram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Hectogram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Kilogram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.MetricTon:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Kilotonne:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Ounce:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMassUnit.Pound:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMassUnit.Stone:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsMassUnit.Quarter:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsMassUnit.HundredweightUS:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsMassUnit.HundredweightUK:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsMassUnit.ShortTon:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsMassUnit.LongTon:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsMassUnit.Grain:
                    return UnitToolsUnitSystem.Troy;
                case UnitToolsMassUnit.Pennyweight:
                    return UnitToolsUnitSystem.Troy;
                case UnitToolsMassUnit.TroyOunce:
                    return UnitToolsUnitSystem.Troy;
                case UnitToolsMassUnit.TroyPound:
                    return UnitToolsUnitSystem.Troy;
                case UnitToolsMassUnit.Carat:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Slug:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsMassUnit.AtomicMassUnit:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMassUnit.Femtogram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Picogram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Nanogram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Megagram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Gigagram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Teragram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Petagram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Megatonne:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Gigatonne:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassUnit.Dram:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMassUnit.ApothecariesScruple:
                    return UnitToolsUnitSystem.Apothecaries;
                case UnitToolsMassUnit.ApothecariesDram:
                    return UnitToolsUnitSystem.Apothecaries;
                case UnitToolsMassUnit.ApothecariesOunce:
                    return UnitToolsUnitSystem.Apothecaries;
                case UnitToolsMassUnit.ApothecariesPound:
                    return UnitToolsUnitSystem.Apothecaries;
                case UnitToolsMassUnit.ElectronMass:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMassUnit.ProtonMass:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMassUnit.NeutronMass:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMassUnit.PlanckMass:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMassUnit.EarthMass:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsMassUnit.JupiterMass:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsMassUnit.SolarMass:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsMassUnit.Shekel:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsMassUnit.Mina:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsMassUnit.Talent:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsMassUnit.Mark:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsMassUnit.Oka:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsMassUnit.Catty:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsMassUnit.Tael:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsMassUnit.Momme:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsMassUnit.PlanckMassGram:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsMassUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsMassUnit.Microgram, UnitToolsMassUnit.Milligram, UnitToolsMassUnit.Centigram, UnitToolsMassUnit.Decigram, UnitToolsMassUnit.Gram, UnitToolsMassUnit.Decagram, UnitToolsMassUnit.Hectogram, UnitToolsMassUnit.Kilogram, UnitToolsMassUnit.MetricTon, UnitToolsMassUnit.Kilotonne, UnitToolsMassUnit.Carat, UnitToolsMassUnit.Femtogram, UnitToolsMassUnit.Picogram, UnitToolsMassUnit.Nanogram, UnitToolsMassUnit.Megagram, UnitToolsMassUnit.Gigagram, UnitToolsMassUnit.Teragram, UnitToolsMassUnit.Petagram, UnitToolsMassUnit.Megatonne, UnitToolsMassUnit.Gigatonne };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsMassUnit.Ounce, UnitToolsMassUnit.Pound, UnitToolsMassUnit.Dram };
                case UnitToolsUnitSystem.ImperialUK:
                    return new[] { UnitToolsMassUnit.Stone, UnitToolsMassUnit.Quarter, UnitToolsMassUnit.HundredweightUK, UnitToolsMassUnit.LongTon };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsMassUnit.HundredweightUS, UnitToolsMassUnit.ShortTon };
                case UnitToolsUnitSystem.Troy:
                    return new[] { UnitToolsMassUnit.Grain, UnitToolsMassUnit.Pennyweight, UnitToolsMassUnit.TroyOunce, UnitToolsMassUnit.TroyPound };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsMassUnit.Slug };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsMassUnit.AtomicMassUnit, UnitToolsMassUnit.ElectronMass, UnitToolsMassUnit.ProtonMass, UnitToolsMassUnit.NeutronMass, UnitToolsMassUnit.PlanckMass, UnitToolsMassUnit.PlanckMassGram };
                case UnitToolsUnitSystem.Apothecaries:
                    return new[] { UnitToolsMassUnit.ApothecariesScruple, UnitToolsMassUnit.ApothecariesDram, UnitToolsMassUnit.ApothecariesOunce, UnitToolsMassUnit.ApothecariesPound };
                case UnitToolsUnitSystem.Astronomical:
                    return new[] { UnitToolsMassUnit.EarthMass, UnitToolsMassUnit.JupiterMass, UnitToolsMassUnit.SolarMass };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsMassUnit.Shekel, UnitToolsMassUnit.Mina, UnitToolsMassUnit.Talent, UnitToolsMassUnit.Mark, UnitToolsMassUnit.Oka, UnitToolsMassUnit.Catty, UnitToolsMassUnit.Tael, UnitToolsMassUnit.Momme };
                default:
                    return new[] { UnitToolsMassUnit.Microgram, UnitToolsMassUnit.Milligram, UnitToolsMassUnit.Centigram, UnitToolsMassUnit.Decigram, UnitToolsMassUnit.Gram, UnitToolsMassUnit.Decagram, UnitToolsMassUnit.Hectogram, UnitToolsMassUnit.Kilogram, UnitToolsMassUnit.MetricTon, UnitToolsMassUnit.Kilotonne, UnitToolsMassUnit.Ounce, UnitToolsMassUnit.Pound, UnitToolsMassUnit.Stone, UnitToolsMassUnit.Quarter, UnitToolsMassUnit.HundredweightUS, UnitToolsMassUnit.HundredweightUK, UnitToolsMassUnit.ShortTon, UnitToolsMassUnit.LongTon, UnitToolsMassUnit.Grain, UnitToolsMassUnit.Pennyweight, UnitToolsMassUnit.TroyOunce, UnitToolsMassUnit.TroyPound, UnitToolsMassUnit.Carat, UnitToolsMassUnit.Slug, UnitToolsMassUnit.AtomicMassUnit, UnitToolsMassUnit.Femtogram, UnitToolsMassUnit.Picogram, UnitToolsMassUnit.Nanogram, UnitToolsMassUnit.Megagram, UnitToolsMassUnit.Gigagram, UnitToolsMassUnit.Teragram, UnitToolsMassUnit.Petagram, UnitToolsMassUnit.Megatonne, UnitToolsMassUnit.Gigatonne, UnitToolsMassUnit.Dram, UnitToolsMassUnit.ApothecariesScruple, UnitToolsMassUnit.ApothecariesDram, UnitToolsMassUnit.ApothecariesOunce, UnitToolsMassUnit.ApothecariesPound, UnitToolsMassUnit.ElectronMass, UnitToolsMassUnit.ProtonMass, UnitToolsMassUnit.NeutronMass, UnitToolsMassUnit.PlanckMass, UnitToolsMassUnit.EarthMass, UnitToolsMassUnit.JupiterMass, UnitToolsMassUnit.SolarMass, UnitToolsMassUnit.Shekel, UnitToolsMassUnit.Mina, UnitToolsMassUnit.Talent, UnitToolsMassUnit.Mark, UnitToolsMassUnit.Oka, UnitToolsMassUnit.Catty, UnitToolsMassUnit.Tael, UnitToolsMassUnit.Momme, UnitToolsMassUnit.PlanckMassGram };
            }
        }
    }
}
