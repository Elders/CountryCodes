using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MX is the entry for Mexico in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Mexico, ISO 3166-2 codes are defined for 31 states and 1 federal entity.Mexico City has special status equal to the states.
        /// Each code consists of two parts, separated by a hyphen. The first part is MX, the ISO 3166-1 alpha-2 code of Mexico.The second part is three letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MX
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MX()
        {
            Add(Country.MX, "CMX", "Ciudad de México");
            Add(Country.MX, "AGU", "Aguascalientes");
            Add(Country.MX, "BCN", "Baja California");
            Add(Country.MX, "BCS", "Baja California Sur");
            Add(Country.MX, "CAM", "Campeche");
            Add(Country.MX, "COA", "Coahuila de Zaragoza");
            Add(Country.MX, "COL", "Colima");
            Add(Country.MX, "CHP", "Chiapas");
            Add(Country.MX, "CHH", "Chihuahua");
            Add(Country.MX, "DUR", "Durango");
            Add(Country.MX, "GUA", "Guanajuato");
            Add(Country.MX, "GRO", "Guerrero");
            Add(Country.MX, "HID", "Hidalgo");
            Add(Country.MX, "JAL", "Jalisco");
            Add(Country.MX, "MEX", "México");
            Add(Country.MX, "MIC", "Michoacán de Ocampo");
            Add(Country.MX, "MOR", "Morelos");
            Add(Country.MX, "NAY", "Nayarit");
            Add(Country.MX, "NLE", "Nuevo León");
            Add(Country.MX, "OAX", "Oaxaca");
            Add(Country.MX, "PUE", "Puebla");
            Add(Country.MX, "QUE", "Querétaro");
            Add(Country.MX, "ROO", "Quintana Roo");
            Add(Country.MX, "SLP", "San Luis Potosí");
            Add(Country.MX, "SIN", "Sinaloa");
            Add(Country.MX, "SON", "Sonora");
            Add(Country.MX, "TAB", "Tabasco");
            Add(Country.MX, "TAM", "Tamaulipas");
            Add(Country.MX, "TLA", "Tlaxcala");
            Add(Country.MX, "VER", "Veracruz de Ignacio de la Llave");
            Add(Country.MX, "YUC", "Yucatán");
            Add(Country.MX, "ZAC", "Zacatecas");

            Debug.Assert(_subdivisionsPerCountry[Country.MX].Count == 32, $"{Country.MX} Number of subdivisions is wrong.");
        }
    }
}
