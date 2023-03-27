using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:KW is the entry for Kuwait in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Kuwait, ISO 3166-2 codes are defined for 6 governorates.
        /// Each code consists of two parts, separated by a hyphen.The first part is KW, the ISO 3166-1 alpha-2 code of Kuwait.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:KW
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_KW()
        {
            Add(Country.KW, "AH", "Al Aḩmadī");
            Add(Country.KW, "FA", "Al Farwānīyah");
            Add(Country.KW, "JA", "Al Jahrā’");
            Add(Country.KW, "KU", "Al ‘Āşimah");
            Add(Country.KW, "HA", "Ḩawallī");
            Add(Country.KW, "MU", "Mubārak al Kabīr");

            Debug.Assert(_subdivisionsPerCountry[Country.KW].Count == 6, "Number of subdivisions is wrong.");
        }
    }
}
