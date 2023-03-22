using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CU is the entry for Cuba in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Cuba, ISO 3166-2 codes are defined for 15 provinces and 1 special municipality.The special municipality Isla de la Juventud is not part of any province and administered directly by the central government.
        /// Each code consists of two parts, separated by a hyphen. The first part is CU, the ISO 3166-1 alpha-2 code of Cuba.The second part is two digits:
        ///     01–16 except 02: provinces
        ///     99: special municipality
        /// The code CU-02 was assigned to La Habana Province, which was split into Artemisa and Mayabeque in 2011. The codes for the original 14 provinces were assigned roughly from west to east.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CU
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_CU()
        {
            Add(Country.CU, "15", "Artemisa");
            Add(Country.CU, "09", "Camagüey");
            Add(Country.CU, "08", "Ciego de Ávila");
            Add(Country.CU, "06", "Cienfuegos");
            Add(Country.CU, "12", "Granma");
            Add(Country.CU, "14", "Guantánamo");
            Add(Country.CU, "11", "Holguín");
            Add(Country.CU, "03", "La Habana");
            Add(Country.CU, "10", "Las Tunas");
            Add(Country.CU, "04", "Matanzas");
            Add(Country.CU, "16", "Mayabeque");
            Add(Country.CU, "01", "Pinar del Río");
            Add(Country.CU, "07", "Sancti Spíritus");
            Add(Country.CU, "13", "Santiago de Cuba");
            Add(Country.CU, "05", "Villa Clara");
            Add(Country.CU, "99", "Isla de la Juventud");

            Debug.Assert(_subdivisionsPerCountry[Country.CU].Count == 16, "Number of subdivisions is wrong.");
        }
    }
}
