namespace UnitConverter.Catalog
{
    using System.Collections.Generic;

    internal static class UnitConverterAliasVariants
    {
        public static string[] GetNotationVariants(string symbol)
        {
            if (string.IsNullOrWhiteSpace(symbol))
            {
                return null;
            }

            var aliases = new List<string>();
            string candidate = symbol.Trim();

            AddMicroVariants(aliases, candidate);
            AddPowerVariants(aliases, candidate);
            AddMultiplicationVariants(aliases, candidate);
            AddDegreeVariants(aliases, candidate);

            return aliases.Count == 0 ? null : aliases.ToArray();
        }

        private static void AddMicroVariants(List<string> aliases, string symbol)
        {
            if (symbol.IndexOf('µ') >= 0)
            {
                Add(aliases, symbol.Replace('µ', 'μ'));
                Add(aliases, symbol.Replace("µ", "u"));
            }

            if (symbol.IndexOf('μ') >= 0)
            {
                Add(aliases, symbol.Replace('μ', 'µ'));
                Add(aliases, symbol.Replace("μ", "u"));
            }
        }

        private static void AddPowerVariants(List<string> aliases, string symbol)
        {
            if (symbol.IndexOf('²') >= 0)
            {
                Add(aliases, symbol.Replace("²", "^2"));
            }

            if (symbol.IndexOf('³') >= 0)
            {
                Add(aliases, symbol.Replace("³", "^3"));
            }
        }

        private static void AddMultiplicationVariants(List<string> aliases, string symbol)
        {
            if (symbol.IndexOf('·') >= 0)
            {
                Add(aliases, symbol.Replace('·', '*'));
            }

            if (symbol.IndexOf('⋅') >= 0)
            {
                Add(aliases, symbol.Replace('⋅', '*'));
            }
        }

        private static void AddDegreeVariants(List<string> aliases, string symbol)
        {
            if (symbol.IndexOf('°') >= 0)
            {
                Add(aliases, symbol.Replace("°", "deg "));
                Add(aliases, symbol.Replace("°", "deg"));
            }
        }

        private static void Add(List<string> aliases, string alias)
        {
            if (string.IsNullOrWhiteSpace(alias) || aliases.Contains(alias))
            {
                return;
            }

            aliases.Add(alias);
        }
    }
}
