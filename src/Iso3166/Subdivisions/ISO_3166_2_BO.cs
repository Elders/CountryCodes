using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BO is the entry for the Plurinational State of Bolivia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Bolivia, ISO 3166-2 codes are defined for 9 departments.
        /// Each code consists of two parts, separated by a hyphen.The first part is BO, the ISO 3166-1 alpha-2 code of the Plurinational State of Bolivia.
        /// The second part is a letter, currently used in vehicle registration plates.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BO
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BO()
        {
            Add(Country.BO, "C", "Cochabamba");
            Add(Country.BO, "H", "Chuquisaca");
            Add(Country.BO, "B", "El Beni");
            Add(Country.BO, "L", "La Paz");
            Add(Country.BO, "O", "Oruro");
            Add(Country.BO, "N", "Pando");
            Add(Country.BO, "P", "Potosí");
            Add(Country.BO, "S", "Santa Cruz");
            Add(Country.BO, "T", "Tarija");

            Debug.Assert(_subdivisionsPerCountry[Country.BO].Count == 9, $"{Country.BO} Number of subdivisions is wrong.");
        }
    }
}
