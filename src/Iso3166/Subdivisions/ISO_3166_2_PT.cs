using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:PT is the entry for Portugal in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Portugal, ISO 3166-2 codes are defined for 18 districts and 2 autonomous regions.
        /// Each code consists of two parts, separated by a hyphen. The first part is PT, the ISO 3166-1 alpha-2 code of Portugal.The second part is two digits:
        ///     01–18: districts
        ///     20 and 30: autonomous regions (Azores and Madeira)
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:PT
        /// LastUpdated: 2023-03-16
        /// </remarks>
        internal static void ISO_3166_2_PT()
        {
            Add(Country.PT, "01", "Aveiro");
            Add(Country.PT, "02", "Beja");
            Add(Country.PT, "03", "Braga");
            Add(Country.PT, "04", "Bragança");
            Add(Country.PT, "05", "Castelo Branco");
            Add(Country.PT, "06", "Coimbra");
            Add(Country.PT, "07", "Évora");
            Add(Country.PT, "08", "Faro");
            Add(Country.PT, "09", "Guarda");
            Add(Country.PT, "10", "Leiria");
            Add(Country.PT, "11", "Lisboa");
            Add(Country.PT, "12", "Portalegre");
            Add(Country.PT, "13", "Porto");
            Add(Country.PT, "14", "Santarém");
            Add(Country.PT, "15", "Setúbal");
            Add(Country.PT, "16", "Viana do Castelo");
            Add(Country.PT, "17", "Vila Real");
            Add(Country.PT, "18", "Viseu");
            Add(Country.PT, "20", "Região Autónoma dos Açores");
            Add(Country.PT, "30", "Região Autónoma da Madeira");

            Debug.Assert(_subdivisionsPerCountry[Country.PT].Count == 20, $"{Country.PT} Number of subdivisions is wrong.");
        }
    }
}
