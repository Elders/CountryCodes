using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:AW is the entry for Aruba in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no ISO 3166-2 codes are defined in the entry for Aruba.The territory has no defined subdivisions.
        /// Aruba, a constituent country of the Kingdom of the Netherlands, is officially assigned the ISO 3166-1 alpha-2 code AW. Moreover,
        /// it is also assigned the ISO 3166-2 code NL-AW under the entry for the Netherlands.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AW
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_AW()
        {
            Debug.Assert(_subdivisionsPerCountry[Country.AW].Count == 0, "Number of subdivisions is wrong.");
        }
    }
}
