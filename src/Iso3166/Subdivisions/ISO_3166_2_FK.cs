using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:FK is the entry for the Falkland Islands in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no ISO 3166-2 codes are defined in the entry for the Falkland Islands.The territory has no defined subdivisions.
        /// The Falkland Islands are officially assigned the ISO 3166-1 alpha-2 code FK and named "FALKLAND ISLANDS (MALVINAS)"
        /// in upper case or "Falkland Islands (the) [Malvinas]" in not only lower case short name but also local short name in ISO 3166
        /// as the United Kingdom administers the Falkland Islands and Argentina claims this group of islands as Malvinas.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:FK
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_FK()
        {
            Debug.Assert(_subdivisionsPerCountry.ContainsKey(Country.FK) == false, $"{Country.FK} Number of subdivisions is wrong.");
        }
    }
}
