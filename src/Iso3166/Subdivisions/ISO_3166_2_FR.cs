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
            Add(Country.FR, "ARA", "Auvergne-Rhône-Alpes");
            Add(Country.FR, "BFC", "Bourgogne-Franche-Comté");
            Add(Country.FR, "BRE", "Bretagne");
            Add(Country.FR, "CVL", "Centre-Val de Loire");
            Add(Country.FR, "20R", "Corse");
            Add(Country.FR, "GES", "Grand-Est");
            Add(Country.FR, "HDF", "Hauts-de-France");
            Add(Country.FR, "IDF", "Île-de-France");
            Add(Country.FR, "NOR", "Normandie");
            Add(Country.FR, "NAQ", "Nouvelle-Aquitaine");
            Add(Country.FR, "OCC", "Occitanie");
            Add(Country.FR, "PDL", "Pays-de-la-Loire");
            Add(Country.FR, "PAC", "Provence-Alpes-Côte-d’Azur");
            Add(Country.FR, "01", "Ain");
            Add(Country.FR, "02", "Aisne");
            Add(Country.FR, "03", "Allier");
            Add(Country.FR, "04", "Alpes-de-Haute-Provence");
            Add(Country.FR, "06", "Alpes-Maritimes");
            Add(Country.FR, "6AE", "Alsace");
            Add(Country.FR, "07", "Ardèche");
            Add(Country.FR, "08", "Ardennes");
            Add(Country.FR, "09", "Ariège");
            Add(Country.FR, "10", "Aube");
            Add(Country.FR, "11", "Aude");
            Add(Country.FR, "12", "Aveyron");
            Add(Country.FR, "13", "Bouches-du-Rhône");
            Add(Country.FR, "14", "Calvados");
            Add(Country.FR, "15", "Cantal");
            Add(Country.FR, "16", "Charente");
            Add(Country.FR, "17", "Charente-Maritime");
            Add(Country.FR, "18", "Cher");
            Add(Country.FR, "19", "Corrèze");
            Add(Country.FR, "2A", "Corse-du-Sud");
            Add(Country.FR, "21", "Côte-d'Or");
            Add(Country.FR, "22", "Côtes-d'Armor");
            Add(Country.FR, "23", "Creuse");
            Add(Country.FR, "79", "Deux-Sèvres");
            Add(Country.FR, "24", "Dordogne");
            Add(Country.FR, "25", "Doubs");
            Add(Country.FR, "26", "Drôme");
            Add(Country.FR, "91", "Essonne");
            Add(Country.FR, "27", "Eure");
            Add(Country.FR, "28", "Eure-et-Loir");
            Add(Country.FR, "29", "Finistère");
            Add(Country.FR, "30", "Gard");
            Add(Country.FR, "32", "Gers");
            Add(Country.FR, "33", "Gironde");
            Add(Country.FR, "971", "Guadeloupe");
            Add(Country.FR, "973", "Guyane");
            Add(Country.FR, "2B", "Haute-Corse");
            Add(Country.FR, "31", "Haute-Garonne");
            Add(Country.FR, "43", "Haute-Loire");
            Add(Country.FR, "52", "Haute-Marne");
            Add(Country.FR, "70", "Haute-Saône");
            Add(Country.FR, "74", "Haute-Savoie");
            Add(Country.FR, "87", "Haute-Vienne");
            Add(Country.FR, "05", "Hautes-Alpes");
            Add(Country.FR, "65", "Hautes-Pyrénées");
            Add(Country.FR, "92", "Hauts-de-Seine");
            Add(Country.FR, "34", "Hérault");
            Add(Country.FR, "35", "Ille-et-Vilaine");
            Add(Country.FR, "36", "Indre");
            Add(Country.FR, "37", "Indre-et-Loire");
            Add(Country.FR, "38", "Isère");
            Add(Country.FR, "39", "Jura");
            Add(Country.FR, "974", "La Réunion");
            Add(Country.FR, "40", "Landes");
            Add(Country.FR, "41", "Loir-et-Cher");
            Add(Country.FR, "42", "Loire");
            Add(Country.FR, "44", "Loire-Atlantique");
            Add(Country.FR, "45", "Loiret");
            Add(Country.FR, "46", "Lot");
            Add(Country.FR, "47", "Lot-et-Garonne");
            Add(Country.FR, "48", "Lozère");
            Add(Country.FR, "49", "Maine-et-Loire");
            Add(Country.FR, "50", "Manche");
            Add(Country.FR, "51", "Marne");
            Add(Country.FR, "972", "Martinique");
            Add(Country.FR, "53", "Mayenne");
            Add(Country.FR, "976", "Mayotte");
            Add(Country.FR, "69M", "Métropole de Lyon");
            Add(Country.FR, "54", "Meurthe-et-Moselle");
            Add(Country.FR, "55", "Meuse");
            Add(Country.FR, "56", "Morbihan");
            Add(Country.FR, "57", "Moselle");
            Add(Country.FR, "58", "Nièvre");
            Add(Country.FR, "59", "Nord");
            Add(Country.FR, "60", "Oise");
            Add(Country.FR, "61", "Orne");
            Add(Country.FR, "75C", "Paris");
            Add(Country.FR, "62", "Pas-de-Calais");
            Add(Country.FR, "63", "Puy-de-Dôme");
            Add(Country.FR, "64", "Pyrénées-Atlantiques");
            Add(Country.FR, "66", "Pyrénées-Orientales");
            Add(Country.FR, "69", "Rhône");
            Add(Country.FR, "71", "Saône-et-Loire");
            Add(Country.FR, "72", "Sarthe");
            Add(Country.FR, "73", "Savoie");
            Add(Country.FR, "77", "Seine-et-Marne");
            Add(Country.FR, "76", "Seine-Maritime");
            Add(Country.FR, "93", "Seine-Saint-Denis");
            Add(Country.FR, "80", "Somme");
            Add(Country.FR, "81", "Tarn");
            Add(Country.FR, "82", "Tarn-et-Garonne");
            Add(Country.FR, "90", "Territoire de Belfort");
            Add(Country.FR, "95", "Val-d'Oise");
            Add(Country.FR, "94", "Val-de-Marne");
            Add(Country.FR, "83", "Var");
            Add(Country.FR, "84", "Vaucluse");
            Add(Country.FR, "85", "Vendée");
            Add(Country.FR, "86", "Vienne");
            Add(Country.FR, "88", "Vosges");
            Add(Country.FR, "89", "Yonne");
            Add(Country.FR, "78", "Yvelines");
            Add(Country.FR, "67", "Bas-Rhin");
            Add(Country.FR, "68", "Haut-Rhin");
            Add(Country.FR, "CP", "Clipperton");
            Add(Country.FR, "NC", "Nouvelle-Calédonie");
            Add(Country.FR, "PF", "Polynésie française");
            Add(Country.FR, "BL", "Saint-Barthélemy");
            Add(Country.FR, "MF", "Saint-Martin");
            Add(Country.FR, "PM", "Saint-Pierre-et-Miquelon");
            Add(Country.FR, "TF", "Terres australes françaises");
            Add(Country.FR, "WF", "Wallis-et-Futuna");

            Debug.Assert(_subdivisionsPerCountry[Country.FR].Count == 124, $"{Country.FR} Number of subdivisions is wrong.");
        }
    }
}
