using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:IO is the entry for the British Indian Ocean Territory in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no ISO 3166-2 codes are defined in the entry for the British Indian Ocean Territory.The territory has no defined subdivisions.
        /// The British Indian Ocean Territory is officially assigned the ISO 3166-1 alpha-2 code IO. Diego Garcia, its largest island,
        /// is exceptionally reserved the ISO 3166-1 alpha-2 code DG on the request of the International Telecommunication Union.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:IO
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_IO()
        {
            Debug.Assert(_subdivisionsPerCountry.ContainsKey(Country.IO) == false, $"{Country.IO} Number of subdivisions is wrong.");
        }
    }
}
