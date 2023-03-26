using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:ET is the entry for Ethiopia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Ethiopia, ISO 3166-2 codes are defined for 2 administrations and 11 regional states.
        /// Each code consists of two parts, separated by a hyphen. The first part is ET, the ISO 3166-1 alpha-2 code of Ethiopia.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:ET
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_ET()
        {
            Add(Country.ET, "AA", "Addis Ababa");
            Add(Country.ET, "DD", "Dire Dawa");
            Add(Country.ET, "AF", "Afar");
            Add(Country.ET, "AM", "Amara");
            Add(Country.ET, "BE", "Benshangul-Gumaz");
            Add(Country.ET, "GA", "Gambela Peoples");
            Add(Country.ET, "HA", "Harari People");
            Add(Country.ET, "OR", "Oromia");
            Add(Country.ET, "SI", "Sidama");
            Add(Country.ET, "SO", "Somali");
            Add(Country.ET, "TI", "Tigrai");
            Add(Country.ET, "SN", "Southern Nations");
            Add(Country.ET, "SW", "Southwest Ethiopia Peoples");

            Debug.Assert(_subdivisionsPerCountry[Country.ET].Count == 13, "Number of subdivisions is wrong.");
        }
    }
}
