using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SJ is the entry for Svalbard and Jan Mayen in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO).
        /// The standard defines codes for names of principal subdivisions of all countries coded in ISO 3166-1.
        /// Svalbard and Jan Mayen does not exist as an administrative region, but rather consists of two separate parts of Norway under separate jurisdictions—Svalbard and Jan Mayen.
        /// Further subdivision for Svalbard and Jan Mayen occurs under Norway's entry, ISO 3166-2:NO,
        /// namely NO-21 for Svalbard and NO-22 for Jan Mayen. There are currently no ISO 3166-2 codes for Svalbard and Jan Mayen.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SJ
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_SJ()
        {
            Debug.Assert(_subdivisionsPerCountry.ContainsKey(Country.SJ) == false, $"{Country.SJ} Number of subdivisions is wrong.");
        }
    }
}
