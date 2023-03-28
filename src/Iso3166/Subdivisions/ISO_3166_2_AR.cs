using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:AR is the entry for Argentina in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Argentina, ISO 3166-2 codes are defined for 1 city and 23 provinces.
        /// The city Buenos Aires is the capital of the country and has special status similar to the provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is AR,
        /// the ISO 3166-1 alpha-2 code of Argentina.The second part is a letter,originally used in vehicle registration
        /// plates(the letters I and O are not used since they could be mistaken as 1 and 0 respectively and were left out of license plates), and currently used in postal codes.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AR
        /// LastUpdated: 2023-03-28
        /// </remarks>
        internal static void ISO_3166_2_AR()
        {
            Add(Country.AR, "C", "Ciudad Autónoma de Buenos Aires");
            Add(Country.AR, "B", "Buenos Aires");
            Add(Country.AR, "K", "Catamarca");
            Add(Country.AR, "H", "Chaco");
            Add(Country.AR, "U", "Chubut");
            Add(Country.AR, "X", "Córdoba");
            Add(Country.AR, "W", "Corrientes");
            Add(Country.AR, "E", "Entre Ríos");
            Add(Country.AR, "P", "Formosa");
            Add(Country.AR, "Y", "Jujuy");
            Add(Country.AR, "L", "La Pampa");
            Add(Country.AR, "F", "La Rioja");
            Add(Country.AR, "M", "Mendoza");
            Add(Country.AR, "N", "Misiones");
            Add(Country.AR, "Q", "Neuquén");
            Add(Country.AR, "R", "Río Negro");
            Add(Country.AR, "A", "Salta");
            Add(Country.AR, "J", "San Juan");
            Add(Country.AR, "D", "San Luis");
            Add(Country.AR, "Z", "Santa Cruz");
            Add(Country.AR, "S", "Santa Fe");
            Add(Country.AR, "G", "Santiago del Estero");
            Add(Country.AR, "V", "Tierra del Fuego");
            Add(Country.AR, "T", "Tucumán");

            Debug.Assert(_subdivisionsPerCountry[Country.AR].Count == 24, $"{Country.AR} Number of subdivisions is wrong.");
        }
    }
}
