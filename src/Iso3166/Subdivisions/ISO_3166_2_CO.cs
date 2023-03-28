using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CO is the entry for Colombia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces, states or departments) of all countries coded in ISO 3166-1.
        /// Currently for Colombia, ISO 3166-2 codes are defined for 1 capital district and 32 departments.The capital district of Bogotá has special status equal to the departments.
        /// Each code consists of two parts, separated by a hyphen. The first part is CO, the ISO 3166-1 alpha-2 code of Colombia.The second part is either of the following:
        ///     two letters: capital district
        ///     three letters: departments
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CO
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_CO()
        {
            Add(Country.CO, "DC", "Distrito Capital de Bogotá");
            Add(Country.CO, "AMA", "Amazonas");
            Add(Country.CO, "ANT", "Antioquia");
            Add(Country.CO, "ARA", "Arauca");
            Add(Country.CO, "ATL", "Atlántico");
            Add(Country.CO, "BOL", "Bolívar");
            Add(Country.CO, "BOY", "Boyacá");
            Add(Country.CO, "CAL", "Caldas");
            Add(Country.CO, "CAQ", "Caquetá");
            Add(Country.CO, "CAS", "Casanare");
            Add(Country.CO, "CAU", "Cauca");
            Add(Country.CO, "CES", "Cesar");
            Add(Country.CO, "COR", "Córdoba");
            Add(Country.CO, "CUN", "Cundinamarca");
            Add(Country.CO, "CHO", "Chocó");
            Add(Country.CO, "GUA", "Guainía");
            Add(Country.CO, "GUV", "Guaviare");
            Add(Country.CO, "HUI", "Huila");
            Add(Country.CO, "LAG", "La Guajira");
            Add(Country.CO, "MAG", "Magdalena");
            Add(Country.CO, "MET", "Meta");
            Add(Country.CO, "NAR", "Nariño");
            Add(Country.CO, "NSA", "Norte de Santander");
            Add(Country.CO, "PUT", "Putumayo");
            Add(Country.CO, "QUI", "Quindío");
            Add(Country.CO, "RIS", "Risaralda");
            Add(Country.CO, "SAP", "San Andrés");
            Add(Country.CO, "SAN", "Santander");
            Add(Country.CO, "SUC", "Sucre");
            Add(Country.CO, "TOL", "Tolima");
            Add(Country.CO, "VAC", "Valle del Cauca");
            Add(Country.CO, "VAU", "Vaupés");
            Add(Country.CO, "VID", "Vichada");

            Debug.Assert(_subdivisionsPerCountry[Country.CO].Count == 33, $"{Country.CO} Number of subdivisions is wrong.");
        }
    }
}
