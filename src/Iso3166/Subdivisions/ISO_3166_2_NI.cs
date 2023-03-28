using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:NI is the entry for Nicaragua in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Nicaragua, ISO 3166-2 codes are defined for 15 departments and 2 autonomous regions.
        /// Each code consists of two parts, separated by a hyphen. The first part is NI, the ISO 3166-1 alpha-2 code of Nicaragua.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:NI
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_NI()
        {
            Add(Country.NI, "BO", "Boaco");
            Add(Country.NI, "CA", "Carazo");
            Add(Country.NI, "CI", "Chinandega");
            Add(Country.NI, "CO", "Chontales");
            Add(Country.NI, "ES", "Estelí");
            Add(Country.NI, "GR", "Granada");
            Add(Country.NI, "JI", "Jinotega");
            Add(Country.NI, "LE", "León");
            Add(Country.NI, "MD", "Madriz");
            Add(Country.NI, "MN", "Managua");
            Add(Country.NI, "MS", "Masaya");
            Add(Country.NI, "MT", "Matagalpa");
            Add(Country.NI, "NS", "Nueva Segovia");
            Add(Country.NI, "SJ", "Río San Juan");
            Add(Country.NI, "RI", "Rivas");
            Add(Country.NI, "AN", "Costa Caribe Norte");
            Add(Country.NI, "AS", "Costa Caribe Sur");

            Debug.Assert(_subdivisionsPerCountry[Country.NI].Count == 17, $"{Country.NI} Number of subdivisions is wrong.");
        }
    }
}
