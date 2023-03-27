using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:ZM is the entry for Zambia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Zambia, ISO 3166-2 codes are defined for 10 provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is ZM, the ISO 3166-1 alpha-2 code of Zambia.
        /// The second part is two digits(01–10).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:ZM
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_ZM()
        {
            Add(Country.ZM, "01", "Western");
            Add(Country.ZM, "02", "Central");
            Add(Country.ZM, "03", "Eastern");
            Add(Country.ZM, "04", "Luapula");
            Add(Country.ZM, "05", "Northern");
            Add(Country.ZM, "06", "North-Western");
            Add(Country.ZM, "07", "Southern");
            Add(Country.ZM, "08", "Copperbelt");
            Add(Country.ZM, "09", "Lusaka");
            Add(Country.ZM, "10", "Muchinga");

            Debug.Assert(_subdivisionsPerCountry[Country.ZM].Count == 10, "Number of subdivisions is wrong.");
        }
    }
}
