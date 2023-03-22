using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:KN is the entry for Saint Kitts and Nevis in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Saint Kitts and Nevis, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///     2 states(i.e., the islands of Saint Kitts and Nevis)
        ///     14 parishes
        /// Each code consists of two parts, separated by a hyphen.The first part is KN, the ISO 3166-1 alpha-2 code of Saint Kitts and Nevis. The second part is either of the following:
        ///     one letter: states
        ///     two digits (01–15 except 14): parishes
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:KN
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_KN()
        {
            Add(Country.KN, "K", "Saint Kitts");
            Add(Country.KN, "N", "Nevis");
            Add(Country.KN, "01", "Christ Church Nichola Town");
            Add(Country.KN, "02", "Saint Anne Sandy Point");
            Add(Country.KN, "03", "Saint George Basseterre");
            Add(Country.KN, "04", "Saint George Gingerland");
            Add(Country.KN, "05", "Saint James Windward");
            Add(Country.KN, "06", "Saint John Capisterre");
            Add(Country.KN, "07", "Saint John Figtree");
            Add(Country.KN, "08", "Saint Mary Cayon");
            Add(Country.KN, "09", "Saint Paul Capisterre");
            Add(Country.KN, "10", "Saint Paul Charlestown");
            Add(Country.KN, "11", "Saint Peter Basseterre");
            Add(Country.KN, "12", "Saint Thomas Lowland");
            Add(Country.KN, "13", "Saint Thomas Middle Island");
            Add(Country.KN, "15", "Trinity Palmetto Point");

            Debug.Assert(_subdivisionsPerCountry[Country.KN].Count == 16, "Number of subdivisions is wrong.");
        }
    }
}
