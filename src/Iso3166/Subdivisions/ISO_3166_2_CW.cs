using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CW is the entry for Curaçao in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no ISO 3166-2 codes are defined in the entry for Curaçao.The territory has no defined subdivisions.
        /// Curaçao, a constituent country of the Kingdom of the Netherlands, is officially assigned the ISO 3166-1 alpha-2 code CW. Moreover,
        /// it is also assigned the ISO 3166-2 code NL-CW under the entry for the Netherlands.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CW
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_CW()
        {
            Debug.Assert(_subdivisionsPerCountry.ContainsKey(Country.CW) == false, $"{Country.CW} Number of subdivisions is wrong.");
        }
    }
}
