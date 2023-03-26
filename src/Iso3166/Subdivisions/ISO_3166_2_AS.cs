using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166 - 2:AS is the entry for American Samoa in ISO 3166 - 2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166 - 1.
        /// Currently no ISO 3166 - 2 codes are defined in the entry for American Samoa.
        /// American Samoa, an outlying area of the United States, is officially assigned the ISO 3166 - 1 alpha - 2 code AS.Moreover,
        /// it is also assigned the ISO 3166 - 2 code US - AS under the e
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AS
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_AS()
        {
            Debug.Assert(_subdivisionsPerCountry[Country.AX].Count == 0, "Number of subdivisions is wrong.");
        }
    }
}
