using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:UY is the entry for Uruguay in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Uruguay, ISO 3166-2 codes are defined for 19 departments.
        /// Each code consists of two parts, separated by a hyphen. The first part is UY, the ISO 3166-1 alpha-2 code of Uruguay. The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:UY
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_UY()
        {
            Add(Country.UY, "AR", "Artigas");
            Add(Country.UY, "CA", "Canelones");
            Add(Country.UY, "CL", "Cerro Largo");
            Add(Country.UY, "CO", "Colonia");
            Add(Country.UY, "DU", "Durazno");
            Add(Country.UY, "FS", "Flores");
            Add(Country.UY, "FD", "Florida");
            Add(Country.UY, "LA", "Lavalleja");
            Add(Country.UY, "MA", "Maldonado");
            Add(Country.UY, "MO", "Montevideo");
            Add(Country.UY, "PA", "Paysandú");
            Add(Country.UY, "RN", "Río Negro");
            Add(Country.UY, "RV", "Rivera");
            Add(Country.UY, "RO", "Rocha");
            Add(Country.UY, "SA", "Salto");
            Add(Country.UY, "SJ", "San José");
            Add(Country.UY, "SO", "Soriano");
            Add(Country.UY, "TA", "Tacuarembó");
            Add(Country.UY, "TT", "Treinta y Tres");

            Debug.Assert(_subdivisionsPerCountry[Country.UY].Count == 19, "Number of subdivisions is wrong.");
        }
    }
}
