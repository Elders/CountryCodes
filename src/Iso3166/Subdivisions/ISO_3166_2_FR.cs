using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:FR is the entry for France in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for France, ISO 3166-2 codes are defined for the following subdivisions:
        ///     Metropolitan France(3 levels):
        ///         12 metropolitan regions
        ///         3 metropolitan collectivities with special status
        ///         95 metropolitan departments
        ///         1 European collectivity
        ///     Overseas France:
        ///         1 dependency
        ///         5 overseas collectivities
        ///         1 overseas collectivity with special status
        ///         3 overseas departmental collectivities
        ///         1 overseas territory
        ///         2 overseas unique territorial collectivities
        /// Each code consists of two parts, separated by a hyphen.The first part is FR, the ISO 3166-1 alpha-2 code of France.The second part is either of the following:
        ///     one digit followed by two letters: European collectivity
        ///     two digits: metropolitan departments
        ///     two digits followed by a letter: metropolitan collectivities with special status
        ///     two letters: overseas collectivities, overseas collectivity with special status, overseas territory(matching their ISO 3166-1 alpha-2 codes)
        ///     three letters: metropolitan regions
        ///     three digits: overseas departmental collectivities, overseas unique territorial collectivities
        /// The metropolitan departments use their INSEE codes, which are currently used in postal codes, and used in vehicle registration plates until 2009. INSEE codes are assigned as follows:
        ///     01–89 except 20: departments created before the 20th century, assigned in alphabetical order(prefixes in the form of "Bas-" and "Haute-" are ignored at the primary sort level), except Paris and Yvelines, which replaced the former departments Seine and Seine-et-Oise respectively after the reorganization of the Paris region in 1968;
        ///     90: Territoire de Belfort, which was given department status in 1922;
        ///     91–95: departments created after the reorganization of the Paris region in 1968;
        ///     2A and 2B: Corse-du-Sud and Haute-Corse, which were created after the division of Corsica in 1975, whose INSEE code was 20.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:FR
        /// LastUpdated: 2023-03-16
        /// </remarks>
        internal static void ISO_3166_2_FR()
        {
            Add(Country.LU, "CA", "Capellen");
            Add(Country.LU, "CL", "Clerf");
            Add(Country.LU, "DI", "Diekirch");
            Add(Country.LU, "EC", "Echternach");
            Add(Country.LU, "ES", "Esch an der Alzette");
            Add(Country.LU, "GR", "Grevenmacher");
            Add(Country.LU, "LU", "Luxemburg");
            Add(Country.LU, "ME", "Mersch");
            Add(Country.LU, "RD", "Redingen");
            Add(Country.LU, "RM", "Remich");
            Add(Country.LU, "VD", "Vianden");
            Add(Country.LU, "WI", "Wiltz");
            Add(Country.LU, "D", "Diekirch");
            Add(Country.LU, "G", "Grevenmacher");
            Add(Country.LU, "L", "Luxemburg");

            Debug.Assert(_subdivisionsPerCountry[Country.FR].Count == 15, "Number of subdivisions is wrong.");
        }
    }
}
