using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:PE is the entry for Peru in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Peru, ISO 3166-2 codes are defined for 25 regions and 1 municipality.
        /// The Metropolitan Municipality of Lima contains the capital of the country Lima and has special status equal to the regions.
        /// Each code consists of two parts, separated by a hyphen. The first part is PE, the ISO 3166-1 alpha-2 code of Peru.The second part is three letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:PE
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_PE()
        {
            Add(Country.PE, "LMA", "Municipalidad Metropolitana de Lima");
            Add(Country.PE, "AMA", "Amazonas");
            Add(Country.PE, "ANC", "Ancash");
            Add(Country.PE, "APU", "Apurímac");
            Add(Country.PE, "ARE", "Arequipa");
            Add(Country.PE, "AYA", "Ayacucho");
            Add(Country.PE, "CAJ", "Cajamarca");
            Add(Country.PE, "CUS", "Cusco");
            Add(Country.PE, "CAL", "El Callao");
            Add(Country.PE, "HUV", "Huancavelica");
            Add(Country.PE, "HUC", "Huánuco");
            Add(Country.PE, "ICA", "Ica");
            Add(Country.PE, "JUN", "Junín");
            Add(Country.PE, "LAL", "La Libertad");
            Add(Country.PE, "LAM", "Lambayeque");
            Add(Country.PE, "LIM", "Lima");
            Add(Country.PE, "LOR", "Loreto");
            Add(Country.PE, "MDD", "Madre de Dios");
            Add(Country.PE, "MOQ", "Moquegua");
            Add(Country.PE, "PAS", "Pasco");
            Add(Country.PE, "PIU", "Piura");
            Add(Country.PE, "PUN", "Puno");
            Add(Country.PE, "SAM", "San Martín");
            Add(Country.PE, "TAC", "Tacna");
            Add(Country.PE, "TUM", "Tumbes");
            Add(Country.PE, "UCA", "Ucayali");

            Debug.Assert(_subdivisionsPerCountry[Country.PE].Count == 26, "Number of subdivisions is wrong.");
        }
    }
}
