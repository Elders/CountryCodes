using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CL is the entry for Chile in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Chile, ISO 3166-2 codes are defined for 16 regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is CL, the ISO 3166-1 alpha-2 code of Chile.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CL
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_CL()
        {
            Add(Country.CL, "AI", "Aisén del General Carlos Ibañez del Campo");
            Add(Country.CL, "AN", "Antofagasta");
            Add(Country.CL, "AP", "Arica y Parinacota");
            Add(Country.CL, "AT", "Atacama");
            Add(Country.CL, "BI", "Biobío");
            Add(Country.CL, "CO", "Coquimbo");
            Add(Country.CL, "AR", "La Araucanía");
            Add(Country.CL, "LI", "Libertador General Bernardo O'Higgins");
            Add(Country.CL, "LL", "Los Lagos");
            Add(Country.CL, "LR", "Los Ríos");
            Add(Country.CL, "MA", "Magallanes");
            Add(Country.CL, "ML", "Maule");
            Add(Country.CL, "NB", "Ñuble");
            Add(Country.CL, "RM", "Región Metropolitana de Santiago");
            Add(Country.CL, "TA", "Tarapacá");
            Add(Country.CL, "VS", "Valparaíso");

            Debug.Assert(_subdivisionsPerCountry[Country.CL].Count == 16, "Number of subdivisions is wrong.");
        }
    }
}
