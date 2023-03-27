using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:AG is the entry for Antigua and Barbuda in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Antigua and Barbuda, ISO 3166-2 codes are defined for 6 parishes and 2 dependencies.
        /// Each code consists of two parts, separated by a hyphen.The first part is AG, the ISO 3166-1 alpha-2 code of Antigua and Barbuda.The second part is two digits:
        ///     03–08: parishes(all on the island of Antigua)
        ///     10–11: dependencies(Barbuda and Redonda)
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AG
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_AG()
        {
            Add(Country.AG, "03", "Saint George");
            Add(Country.AG, "04", "Saint John");
            Add(Country.AG, "05", "Saint Mary");
            Add(Country.AG, "06", "Saint Paul");
            Add(Country.AG, "07", "Saint Peter");
            Add(Country.AG, "08", "Saint Philip");
            Add(Country.AG, "10", "Barbuda");
            Add(Country.AG, "11", "Redonda");

            Debug.Assert(_subdivisionsPerCountry[Country.AG].Count == 8, "Number of subdivisions is wrong.");
        }
    }
}
