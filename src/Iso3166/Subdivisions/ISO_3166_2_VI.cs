using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:VI is the entry for the United States Virgin Islands in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no ISO 3166-2 codes are defined in the entry for the United States Virgin Islands.
        /// The United States Virgin Islands, an outlying area of the United States, are officially assigned the ISO 3166-1 alpha-2 code VI.Moreover,
        /// it is also assigned the ISO 3166-2 code US-VI under the entry for the United States.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:VI
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_VI()
        {
            Debug.Assert(_subdivisionsPerCountry.ContainsKey(Country.VI) == false, $"{Country.VI} Number of subdivisions is wrong.");
        }
    }
}
