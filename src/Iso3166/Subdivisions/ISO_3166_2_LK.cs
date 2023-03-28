using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:LK is the entry for Sri Lanka in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Sri Lanka, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///     9 provinces
        ///     25 districts
        /// Each code consists of two parts, separated by a hyphen.The first part is LK, the ISO 3166-1 alpha-2 code of the Sri Lanka.The second part is either of the following:
        ///     one digit (1–9): provinces
        ///     two digits: districts
        /// For the districts, the first digit is the second part of the ISO 3166-2 code of the province where the district is in.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:LK
        /// LastUpdated: 2023-03-16
        /// </remarks>
        internal static void ISO_3166_2_LK()
        {
            Add(Country.LK, "1", "Western Province");
            Add(Country.LK, "2", "Central Province");
            Add(Country.LK, "3", "Southern Province");
            Add(Country.LK, "4", "Northern Province");
            Add(Country.LK, "5", "Eastern Province");
            Add(Country.LK, "6", "North Western Province");
            Add(Country.LK, "7", "North Central Province");
            Add(Country.LK, "8", "Uva Province");
            Add(Country.LK, "9", "Sabaragamuwa Province");
            Add(Country.LK, "11", "Colombo");
            Add(Country.LK, "12", "Gampaha");
            Add(Country.LK, "13", "Kalutara");
            Add(Country.LK, "21", "Kandy");
            Add(Country.LK, "22", "Matale");
            Add(Country.LK, "23", "Nuwara Eliya");
            Add(Country.LK, "31", "Galle");
            Add(Country.LK, "32", "Matara");
            Add(Country.LK, "33", "Hambantota");
            Add(Country.LK, "41", "Jaffna");
            Add(Country.LK, "42", "Kilinochchi");
            Add(Country.LK, "43", "Mannar");
            Add(Country.LK, "44", "Vavuniya");
            Add(Country.LK, "45", "Mullaittivu");
            Add(Country.LK, "51", "Batticaloa");
            Add(Country.LK, "52", "Ampara");
            Add(Country.LK, "53", "Trincomalee");
            Add(Country.LK, "61", "Kurunegala");
            Add(Country.LK, "62", "Puttalam");
            Add(Country.LK, "71", "Anuradhapura");
            Add(Country.LK, "72", "Polonnaruwa");
            Add(Country.LK, "81", "Badulla");
            Add(Country.LK, "82", "Monaragala");
            Add(Country.LK, "91", "Ratnapura");
            Add(Country.LK, "92", "Kegalla");

            Debug.Assert(_subdivisionsPerCountry[Country.LK].Count == 34, $"{Country.LK} Number of subdivisions is wrong.");
        }
    }
}
