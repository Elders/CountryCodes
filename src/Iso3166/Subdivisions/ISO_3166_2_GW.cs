using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:GW is the entry for Guinea-Bissau in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Guinea-Bissau, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///     3 provinces
        ///     1 autonomous sector and 8 regions
        /// The autonomous sector Bissau is the capital of the country and has special status equal to the regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is GW, the ISO 3166-1 alpha-2 code of Guinea-Bissau.The second part is either of the following:
        ///     one letter: provinces
        ///     two letters: autonomous sector and regions
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:GW
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_GW()
        {
            Add(Country.GW, "L", "Leste");
            Add(Country.GW, "N", "Norte");
            Add(Country.GW, "S", "Sul");
            Add(Country.GW, "BS", "Bissau");
            Add(Country.GW, "BA", "Bafatá");
            Add(Country.GW, "BM", "Biombo");
            Add(Country.GW, "BL", "Bolama");
            Add(Country.GW, "CA", "Cacheu");
            Add(Country.GW, "GA", "Gabú");
            Add(Country.GW, "OI", "Oio");
            Add(Country.GW, "QU", "Quinara");
            Add(Country.GW, "TO", "Tombali");

            Debug.Assert(_subdivisionsPerCountry[Country.GW].Count == 12, $"{Country.GW} Number of subdivisions is wrong.");
        }
    }
}
