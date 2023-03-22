using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BR is the entry for Brazil in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO), which defines codes for the names of the principal subdivisions (e.g. provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Brazil, ISO 3166-2 codes are defined for 26 states and 1 federal district. The Federal District has a special status similar to the states.
        /// Each code consists of two parts, separated by a hyphen. The first part is BR, the ISO 3166-1 alpha-2 code of Brazil. The second part is two letters, widely used in Brazil as abbreviations of the states and federal district. 
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BR
        /// LastUpdated: 2023-03-15
        /// </remarks>
        internal static void ISO_3166_2_BR()
        {
            Add(Country.BR, "AC", "Acre");
            Add(Country.BR, "AL", "Alagoas");
            Add(Country.BR, "AP", "Amapá");
            Add(Country.BR, "AM", "Amazonas");
            Add(Country.BR, "BA", "Bahia");
            Add(Country.BR, "CE", "Ceará");
            Add(Country.BR, "DF", "Distrito Federal");
            Add(Country.BR, "ES", "Espírito Santo");
            Add(Country.BR, "GO", "Goiás");
            Add(Country.BR, "MA", "Maranhão");
            Add(Country.BR, "MT", "Mato Grosso");
            Add(Country.BR, "MS", "Mato Grosso do Sul");
            Add(Country.BR, "MG", "Minas Gerais");
            Add(Country.BR, "PA", "Pará");
            Add(Country.BR, "PB", "Paraíba");
            Add(Country.BR, "PR", "Paraná");
            Add(Country.BR, "PE", "Pernambuco");
            Add(Country.BR, "PI", "Piauí");
            Add(Country.BR, "RJ", "Rio de Janeiro");
            Add(Country.BR, "RN", "Rio Grande do Norte");
            Add(Country.BR, "RS", "Rio Grande do Sul");
            Add(Country.BR, "RO", "Rondônia");
            Add(Country.BR, "RR", "Roraima");
            Add(Country.BR, "SC", "Santa Catarina");
            Add(Country.BR, "SP", "São Paulo");
            Add(Country.BR, "SE", "Sergipe");
            Add(Country.BR, "TO", "Tocantins");

            Debug.Assert(_subdivisionsPerCountry[Country.BR].Count == 27, "Number of subdivisions is wrong.");
        }
    }
}
