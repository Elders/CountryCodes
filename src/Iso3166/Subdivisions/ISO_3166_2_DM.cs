using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:DM is the entry for Dominica in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Dominica, ISO 3166-2 codes are defined for 10 parishes.
        /// Each code consists of two parts, separated by a hyphen.The first part is DM, the ISO 3166-1 alpha-2 code of Dominica.The second part is two digits(02–11).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:DM
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_DM()
        {
            Add(Country.DM, "02", "Saint Andrew");
            Add(Country.DM, "03", "Saint David");
            Add(Country.DM, "04", "Saint George");
            Add(Country.DM, "05", "Saint John");
            Add(Country.DM, "06", "Saint Joseph");
            Add(Country.DM, "07", "Saint Luke");
            Add(Country.DM, "08", "Saint Mark");
            Add(Country.DM, "09", "Saint Patrick");
            Add(Country.DM, "10", "Saint Paul");
            Add(Country.DM, "11", "Saint Peter");

            Debug.Assert(_subdivisionsPerCountry[Country.DM].Count == 10, "Number of subdivisions is wrong.");
        }
    }
}
