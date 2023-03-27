using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CA is the entry for Canada in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO), which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Canada, ISO 3166-2 codes are defined for 10 provinces and 3 territories.
        /// Each code consists of two parts, separated by a hyphen.The first part is CA, the ISO 3166-1 alpha-2 code of Canada.The second part is two letters, which is the postal abbreviation for the province or territory.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CA
        /// LastUpdated: 2023-03-15
        /// </remarks>
        internal static void ISO_3166_2_CA()
        {
            Add(Country.CA, "AB", "Alberta");
            Add(Country.CA, "BC", "British Columbia");
            Add(Country.CA, "MB", "Manitoba");
            Add(Country.CA, "NB", "New Brunswick");
            Add(Country.CA, "NL", "Newfoundland and Labrador");
            Add(Country.CA, "NS", "Nova Scotia");
            Add(Country.CA, "ON", "Ontario");
            Add(Country.CA, "PE", "Prince Edward Island");
            Add(Country.CA, "QC", "Quebec");
            Add(Country.CA, "SK", "Saskatchewan");
            Add(Country.CA, "NT", "Northwest Territories");
            Add(Country.CA, "NU", "Nunavut");
            Add(Country.CA, "YT", "Yukon");

            Debug.Assert(_subdivisionsPerCountry[Country.CA].Count == 13, "Number of subdivisions is wrong.");
        }
    }
}
