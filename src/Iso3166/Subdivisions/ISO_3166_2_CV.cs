using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:CV is the entry for Cabo Verde in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Cabo Verde, ISO 3166-2 codes are defined for two levels of subdivisions:
        ///         2 geographical regions(i.e., the Barlavento Islands and the Sotavento Islands)
        ///         22 municipalities
        /// Each code consists of two parts, separated by a hyphen.The first part is CV, the ISO 3166-1 alpha-2 code of Cabo Verde. The second part is either of the following:
        ///         one letter: geographical regions
        ///         two letters: municipalities
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:CV
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_CV()
        {
            Add(Country.CV, "B", "Ilhas de Barlavento");
            Add(Country.CV, "S", "Ilhas de Sotavento");
            Add(Country.CV, "BV", "Boa Vista");
            Add(Country.CV, "BR", "Brava");
            Add(Country.CV, "MA", "Maio");
            Add(Country.CV, "MO", "Mosteiros");
            Add(Country.CV, "PA", "Paul");
            Add(Country.CV, "PN", "Porto Novo");
            Add(Country.CV, "PR", "Praia");
            Add(Country.CV, "RB", "Ribeira Brava");
            Add(Country.CV, "RG", "Ribeira Grande");
            Add(Country.CV, "RS", "Ribeira Grande de Santiago");
            Add(Country.CV, "SL", "Sal");
            Add(Country.CV, "CA", "Santa Catarina");
            Add(Country.CV, "CF", "Santa Catarina do Fogo");
            Add(Country.CV, "CR", "Santa Cruz");
            Add(Country.CV, "SD", "São Domingos");
            Add(Country.CV, "SF", "São Filipe");
            Add(Country.CV, "SO", "São Lourenço dos Órgãos");
            Add(Country.CV, "SM", "São Miguel");
            Add(Country.CV, "SS", "São Salvador do Mundo");
            Add(Country.CV, "SV", "São Vicente");
            Add(Country.CV, "TA", "Tarrafal");
            Add(Country.CV, "TS", "Tarrafal de São Nicolau");

            Debug.Assert(_subdivisionsPerCountry[Country.CV].Count == 24, "Number of subdivisions is wrong.");
        }
    }
}
