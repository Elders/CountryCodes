using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:NF is the entry for Norfolk Island in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no ISO 3166-2 codes are defined in the entry for Norfolk Island.The territory has no defined subdivisions.
        /// Norfolk Island is officially assigned the ISO 3166-1 alpha-2 code NF.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:NF
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_NF()
        {
            Debug.Assert(_subdivisionsPerCountry.ContainsKey(Country.NF) == false, $"{Country.NF} Number of subdivisions is wrong.");
        }
    }
}
