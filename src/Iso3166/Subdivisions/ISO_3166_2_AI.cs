using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:AI is the entry for Anguilla in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no ISO 3166-2 codes are defined in the entry for Anguilla.
        /// Anguilla is officially assigned the ISO 3166-1 alpha-2 code AI.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AI
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_AI()
        {
            Debug.Assert(_subdivisionsPerCountry.ContainsKey(Country.AI) == false, $"{Country.AI} Number of subdivisions is wrong.");
        }
    }
}
