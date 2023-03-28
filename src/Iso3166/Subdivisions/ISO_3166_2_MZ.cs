using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MZ is the entry for Mozambique in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Mozambique, ISO 3166-2 codes are defined for 1 city and 10 provinces.The city Maputo is the capital of the country and has special status equal to the provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is MZ, the ISO 3166-1 alpha-2 code of Mozambique.The second part is either of the following:
        ///     one letter: provinces
        ///     three letters: city
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MZ
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MZ()
        {
            Add(Country.MZ, "MPM", "Maputo");
            Add(Country.MZ, "P", "Cabo Delgado");
            Add(Country.MZ, "G", "Gaza");
            Add(Country.MZ, "I", "Inhambane");
            Add(Country.MZ, "B", "Manica");
            Add(Country.MZ, "L", "Maputo");
            Add(Country.MZ, "N", "Nampula");
            Add(Country.MZ, "A", "Niassa");
            Add(Country.MZ, "S", "Sofala");
            Add(Country.MZ, "T", "Tete");
            Add(Country.MZ, "Q", "Zambézia");

            Debug.Assert(_subdivisionsPerCountry[Country.MZ].Count == 11, $"{Country.MZ} Number of subdivisions is wrong.");
        }
    }
}
