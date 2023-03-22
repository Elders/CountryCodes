using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BB is the entry for Barbados in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Barbados, ISO 3166-2 codes are defined for 11 parishes.
        /// Each code consists of two parts, separated by a hyphen.The first part is BB, the ISO 3166-1 alpha-2 code of Barbados.The second part is two digits(01–11).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BB
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BB()
        {
            Add(Country.BB, "01", "Christ Church");
            Add(Country.BB, "02", "Saint Andrew");
            Add(Country.BB, "03", "Saint George");
            Add(Country.BB, "04", "Saint James");
            Add(Country.BB, "05", "Saint John");
            Add(Country.BB, "06", "Saint Joseph");
            Add(Country.BB, "07", "Saint Lucy");
            Add(Country.BB, "08", "Saint Michael");
            Add(Country.BB, "09", "Saint Peter");
            Add(Country.BB, "10", "Saint Philip");
            Add(Country.BB, "11", "Saint Thomas");

            Debug.Assert(_subdivisionsPerCountry[Country.BB].Count == 11, "Number of subdivisions is wrong.");
        }
    }
}
