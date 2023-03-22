using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SH is the entry for Saint Helena, Ascension and Tristan da Cunha in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Saint Helena, Ascension and Tristan da Cunha, ISO 3166-2 codes are defined for 3 geographical entities.
        /// Each code consists of two parts, separated by a hyphen. The first part is SH, the ISO 3166-1 alpha-2 code of Saint Helena, Ascension and Tristan da Cunha.The second part is two letters.
        /// Ascension Island and Tristan da Cunha, previously dependencies of Saint Helena but raised to equal status in 2009,
        /// are exceptionally reserved the ISO 3166-1 alpha-2 codes AC and TA respectively on the request of the Universal Postal Union.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SH
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_SH()
        {
            Add(Country.SH, "AC", "Ascension");
            Add(Country.SH, "HL", "Saint Helena");
            Add(Country.SH, "TA", "Tristan da Cunha");

            Debug.Assert(_subdivisionsPerCountry[Country.SH].Count == 3, "Number of subdivisions is wrong.");
        }
    }
}
