using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:GD is the entry for Grenada in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Grenada, ISO 3166-2 codes are defined for 6 parishes and 1 dependency.
        /// Each code consists of two parts, separated by a hyphen.The first part is GD, the ISO 3166-1 alpha-2 code of Grenada.The second part is two digits:
        ///     01–06: parishes(all on the island of Grenada)
        ///     10: dependency(Carriacou and Petite Martinique, in the southern part of the Grenadines)
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:GD
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_GD()
        {
            Add(Country.GD, "01", "Saint Andrew");
            Add(Country.GD, "02", "Saint David");
            Add(Country.GD, "03", "Saint George");
            Add(Country.GD, "04", "Saint John");
            Add(Country.GD, "05", "Saint Mark");
            Add(Country.GD, "06", "Saint Patrick");
            Add(Country.GD, "10", "Southern Grenadine Islands");

            Debug.Assert(_subdivisionsPerCountry[Country.GD].Count == 7, $"{Country.GD} Number of subdivisions is wrong.");
        }
    }
}
