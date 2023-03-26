using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:RE is the entry for Réunion in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no ISO 3166-2 codes are defined in the entry for Réunion.
        /// Réunion, an overseas region/department of France, is officially assigned the ISO 3166-1 alpha-2 code RE.Moreover,
        /// it is also assigned the ISO 3166-2 code FR-974 under the entry for France.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:RE
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_RE()
        {
            Debug.Assert(_subdivisionsPerCountry[Country.RE].Count == 0, "Number of subdivisions is wrong.");
        }
    }
}
