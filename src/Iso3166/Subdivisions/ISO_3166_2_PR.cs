using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:PR is the entry for Puerto Rico in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no ISO 3166-2 codes are defined in the entry for Puerto Rico.
        /// Puerto Rico, an outlying area of the United States, is officially assigned the ISO 3166-1 alpha-2 code PR. Moreover,
        /// it is also assigned the ISO 3166-2 code US-PR under the entry for the United States.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:PR
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_PR()
        {
            Debug.Assert(_subdivisionsPerCountry[Country.PR].Count == 0, "Number of subdivisions is wrong.");
        }
    }
}
