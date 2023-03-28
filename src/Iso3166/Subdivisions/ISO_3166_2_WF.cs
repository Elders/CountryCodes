using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:WF is the entry for Wallis and Futuna in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Wallis and Futuna, ISO 3166-2 codes are defined for three administrative precincts.
        /// Each code consists of two parts, separated by a hyphen.The first part is WF, the ISO 3166-1 alpha-2 code of Wallis and Futuna.The second part is two letters.
        /// Wallis and Futuna, an overseas territorial collectivity of France, is officially assigned the ISO 3166-1 alpha-2 code WF. Moreover,
        /// it is also assigned the ISO 3166-2 code FR-WF under the entry for France.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:WF
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_WF()
        {
            Add(Country.WF, "AL", "Alo");
            Add(Country.WF, "SG", "‘Sigave");
            Add(Country.WF, "UV", "Uvea");

            Debug.Assert(_subdivisionsPerCountry[Country.WF].Count == 3, $"{Country.WF} Number of subdivisions is wrong.");
        }
    }
}
