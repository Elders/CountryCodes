using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:TJ is the entry for Tajikistan in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Tajikistan, ISO 3166-2 codes are defined for 1 autonomous region, 2 regions, 1 capital territory, and 1 district under republic administration.
        /// Each code consists of two parts, separated by a hyphen. The first part is TJ, the ISO 3166-1 alpha-2 code of Tajikistan.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:TJ
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_TJ()
        {
            Add(Country.TJ, "DU", "Dushanbe");
            Add(Country.TJ, "GB", "Kŭhistoni Badakhshon");
            Add(Country.TJ, "KT", "Khatlon");
            Add(Country.TJ, "SU", "Sughd");
            Add(Country.TJ, "RA", "nohiyahoi tobei jumhurí");

            Debug.Assert(_subdivisionsPerCountry[Country.TJ].Count == 5, "Number of subdivisions is wrong.");
        }
    }
}
