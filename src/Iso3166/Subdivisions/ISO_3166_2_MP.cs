using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MP is the entry for the Northern Mariana Islands in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1. "MP" stands for "Marianas Pacific".
        /// Currently no ISO 3166-2 codes are defined in the entry for the Northern Mariana Islands.
        /// The Northern Mariana Islands, an outlying area of the United States, are officially assigned the ISO 3166-1 alpha-2 code MP. Moreover,
        /// it is also assigned the ISO 3166-2 code US-MP under the entry for the United States.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MP
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_MP()
        {
            Debug.Assert(_subdivisionsPerCountry.ContainsKey(Country.MP) == false, "Number of subdivisions is wrong.");
        }
    }
}
