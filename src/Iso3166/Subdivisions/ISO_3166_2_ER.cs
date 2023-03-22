using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:ER is the entry for Eritrea in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Eritrea, ISO 3166-2 codes are defined for 6 regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is ER, the ISO 3166-1 alpha-2 code of Eritrea.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:ER
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_ER()
        {
            Add(Country.ER, "MA", "Maekel");
            Add(Country.ER, "DU", "Debub");
            Add(Country.ER, "AN", "Anseba");
            Add(Country.ER, "DK", "Southern Red Sea");
            Add(Country.ER, "GB", "Gash-Barka");
            Add(Country.ER, "SK", "Northern Red Sea");

            Debug.Assert(_subdivisionsPerCountry[Country.ER].Count == 6, "Number of subdivisions is wrong.");
        }
    }
}
