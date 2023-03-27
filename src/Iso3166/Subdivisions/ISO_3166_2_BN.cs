using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BN is the entry for Brunei in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Brunei, ISO 3166-2 codes are defined for 4 districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is BN, the ISO 3166-1 alpha-2 code of Brunei.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BN
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BN()
        {
            Add(Country.BN, "BE", "Belait");
            Add(Country.BN, "BM", "Brunei-Muara");
            Add(Country.BN, "TE", "Temburong");
            Add(Country.BN, "TU", "Tutong");

            Debug.Assert(_subdivisionsPerCountry[Country.BN].Count == 4, "Number of subdivisions is wrong.");
        }
    }
}
