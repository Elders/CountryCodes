using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:VE is the entry for Venezuela in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Venezuela, ISO 3166-2 codes are defined for 1 capital district, 1 federal dependency, and 23 states.
        /// The Venezuelan Capital District contains the central part of the capital of the country Caracas and has special status equal to the states.
        /// Each code consists of two parts, separated by a hyphen. The first part is VE, the ISO 3166-1 alpha-2 code of Venezuela. The second part is a letter:
        ///     A: federal district
        ///     B–V (except Q): states as of late 1980s
        ///     W: federal dependency
        ///     X: state created in 1998
        ///     Y–Z: former federal territories given state status in early 1990s
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:VE
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_VE()
        {
            Add(Country.VE, "Z", "Amazonas");
            Add(Country.VE, "B", "Anzoátegui");
            Add(Country.VE, "C", "Apure");
            Add(Country.VE, "D", "Aragua");
            Add(Country.VE, "E", "Barinas");
            Add(Country.VE, "F", "Bolívar");
            Add(Country.VE, "G", "Carabobo");
            Add(Country.VE, "H", "Cojedes");
            Add(Country.VE, "Y", "Delta Amacuro");
            Add(Country.VE, "W", "Dependencias Federales");
            Add(Country.VE, "A", "Distrito Capital");
            Add(Country.VE, "I", "Falcón");
            Add(Country.VE, "J", "Guárico");
            Add(Country.VE, "X", "La Guaira");
            Add(Country.VE, "K", "Lara");
            Add(Country.VE, "L", "Mérida");
            Add(Country.VE, "M", "Miranda");
            Add(Country.VE, "N", "Monagas");
            Add(Country.VE, "O", "Nueva Esparta");
            Add(Country.VE, "P", "Portuguesa");
            Add(Country.VE, "R", "Sucre");
            Add(Country.VE, "S", "Táchira");
            Add(Country.VE, "T", "Trujillo");
            Add(Country.VE, "U", "Yaracuy");
            Add(Country.VE, "V", "Zulia");

            Debug.Assert(_subdivisionsPerCountry[Country.VE].Count == 25, "Number of subdivisions is wrong.");
        }
    }
}
