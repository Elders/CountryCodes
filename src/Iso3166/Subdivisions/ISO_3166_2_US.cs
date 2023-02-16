using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:US is the entry for the United States in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO), which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for the United States, ISO 3166-2 codes are defined for the following subdivisions:
        /// - 50 states
        /// - 1 district(i.e., the District of Columbia, the capital of the country, also known as Washington DC)
        /// - 6 outlying areas(including the United States Minor Outlying Islands, a collection of nine islands or groups of islands)
        /// Each code consists of two parts, separated by a hyphen.The first part is US, the ISO 3166-1 alpha-2 code of the United States.The second part is two letters, which is the postal abbreviation of the state, district, or outlying area, except the United States Minor Outlying Islands which do not have a postal abbreviation.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:US
        /// LastUpdated: 2023-02-16
        /// </remarks>
        internal static void ISO_3166_2_US()
        {
            Add(Country.US, "AL", "Alabama");
            Add(Country.US, "AK", "Alaska");
            Add(Country.US, "AS", "American Samoa");
            Add(Country.US, "AZ", "Arizona");
            Add(Country.US, "AR", "Arkansas");
            Add(Country.US, "CA", "California");
            Add(Country.US, "CO", "Colorado");
            Add(Country.US, "CT", "Connecticut");
            Add(Country.US, "DE", "Delaware");
            Add(Country.US, "DC", "District of Columbia");
            Add(Country.US, "FL", "Florida");
            Add(Country.US, "GA", "Georgia");
            Add(Country.US, "GU", "Guam");
            Add(Country.US, "HI", "Hawaii");
            Add(Country.US, "ID", "Idaho");
            Add(Country.US, "IL", "Illinois");
            Add(Country.US, "IN", "Indiana");
            Add(Country.US, "IA", "Iowa");
            Add(Country.US, "KS", "Kansas");
            Add(Country.US, "KY", "Kentucky");
            Add(Country.US, "LA", "Louisiana");
            Add(Country.US, "ME", "Maine");
            Add(Country.US, "MD", "Maryland");
            Add(Country.US, "MA", "Massachusetts");
            Add(Country.US, "MI", "Michigan");
            Add(Country.US, "MN", "Minnesota");
            Add(Country.US, "MS", "Mississippi");
            Add(Country.US, "MO", "Missouri");
            Add(Country.US, "MT", "Montana");
            Add(Country.US, "NE", "Nebraska");
            Add(Country.US, "NV", "Nevada");
            Add(Country.US, "NH", "New Hampshire");
            Add(Country.US, "NJ", "New Jersey");
            Add(Country.US, "NM", "New Mexico");
            Add(Country.US, "NY", "New York");
            Add(Country.US, "NC", "North Carolina");
            Add(Country.US, "ND", "North Dakota");
            Add(Country.US, "MP", "Northern Mariana Islands");
            Add(Country.US, "OH", "Ohio");
            Add(Country.US, "OK", "Oklahoma");
            Add(Country.US, "OR", "Oregon");
            Add(Country.US, "PA", "Pennsylvania");
            Add(Country.US, "PR", "Puerto Rico");
            Add(Country.US, "RI", "Rhode Island");
            Add(Country.US, "SC", "South Carolina");
            Add(Country.US, "SD", "South Dakota");
            Add(Country.US, "TN", "Tennessee");
            Add(Country.US, "TX", "Texas");
            Add(Country.US, "UM", "United States Minor Outlying Islands");
            Add(Country.US, "UT", "Utah");
            Add(Country.US, "VT", "Vermont");
            Add(Country.US, "VA", "Virginia");
            Add(Country.US, "VI", "Virgin Islands, U.S.");
            Add(Country.US, "WA", "Washington");
            Add(Country.US, "WV", "West Virginia");
            Add(Country.US, "WI", "Wisconsin");
            Add(Country.US, "WY", "Wyoming");
        }
    }
}
