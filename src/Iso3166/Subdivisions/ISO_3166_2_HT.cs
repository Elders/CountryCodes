using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:HT is the entry for Haiti in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Haiti, ISO 3166-2 codes are defined for 10 departments.
        /// Each code consists of two parts, separated by a hyphen.The first part is HT, the ISO 3166-1 alpha-2 code of Haiti.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:HT
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_HT()
        {
            Add(Country.HT, "AR", "Artibonite");
            Add(Country.HT, "CE", "Centre");
            Add(Country.HT, "GA", "Grande’Anse");
            Add(Country.HT, "NI", "Nippes");
            Add(Country.HT, "ND", "Nord");
            Add(Country.HT, "NE", "Nord-Est");
            Add(Country.HT, "NO", "Nord-Ouest");
            Add(Country.HT, "OU", "Ouest");
            Add(Country.HT, "SD", "Sud");
            Add(Country.HT, "SE", "Sud-Est");

            Debug.Assert(_subdivisionsPerCountry[Country.HT].Count == 10, $"{Country.HT} Number of subdivisions is wrong.");
        }
    }
}
