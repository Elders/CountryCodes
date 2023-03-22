using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:EC is the entry for Ecuador in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Ecuador, ISO 3166-2 codes are defined for 24 provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is EC, the ISO 3166-1 alpha-2 code of Ecuador.The second part is one or two letters,
        /// currently used in vehicle registration plates, with a few exceptions.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:EC
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_EC()
        {
            Add(Country.EC, "A", "Azuay");
            Add(Country.EC, "B", "Bolívar");
            Add(Country.EC, "F", "Cañar");
            Add(Country.EC, "C", "Carchi");
            Add(Country.EC, "H", "Chimborazo");
            Add(Country.EC, "X", "Cotopaxi");
            Add(Country.EC, "O", "El Oro");
            Add(Country.EC, "E", "Esmeraldas");
            Add(Country.EC, "W", "Galápagos");
            Add(Country.EC, "G", "Guayas");
            Add(Country.EC, "I", "Imbabura");
            Add(Country.EC, "L", "Loja");
            Add(Country.EC, "R", "Los Ríos");
            Add(Country.EC, "M", "Manabí");
            Add(Country.EC, "S", "Morona Santiago");
            Add(Country.EC, "N", "Napo");
            Add(Country.EC, "D", "Orellana");
            Add(Country.EC, "Y", "Pastaza");
            Add(Country.EC, "P", "Pichincha");
            Add(Country.EC, "SE", "Santa Elena");
            Add(Country.EC, "SD", "Santo Domingo de los Tsáchilas");
            Add(Country.EC, "U", "Sucumbíos");
            Add(Country.EC, "T", "Tungurahua");
            Add(Country.EC, "Z", "Zamora Chinchipe");

            Debug.Assert(_subdivisionsPerCountry[Country.EC].Count == 24, "Number of subdivisions is wrong.");
        }
    }
}
