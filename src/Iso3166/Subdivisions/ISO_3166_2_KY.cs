using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:KY is the entry for the Cayman Islands in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no second level ISO 3166-2 codes are defined in the entry for the Cayman Islands.
        /// The Cayman Islands are officially assigned the ISO 3166-1 alpha-2 code KY.
        /// This two character string is most commonly associated with the Cayman Island's official internet domain name extension .ky
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:KY
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_KY()
        {
            Debug.Assert(_subdivisionsPerCountry.ContainsKey(Country.KY) == false, $"{Country.KY} Number of subdivisions is wrong.");
        }
    }
}
