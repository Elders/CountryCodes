using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:PA is the entry for Panama in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Panama, ISO 3166-2 codes are defined for 10 provinces and 4 indigenous regions.
        /// Each code consists of two parts, separated by a hyphen. The first part is PA, the ISO 3166-1 alpha-2 code of Panama.The second part is either of the following:
        ///     one or two digits (1–10): provinces
        ///     two letters: indigenous regions
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:PA
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_PA()
        {
            Add(Country.PA, "1", "Bocas del Toro");
            Add(Country.PA, "4", "Chiriquí");
            Add(Country.PA, "2", "Coclé");
            Add(Country.PA, "3", "Colón");
            Add(Country.PA, "5", "Darién");
            Add(Country.PA, "EM", "Emberá");
            Add(Country.PA, "KY", "Guna Yala");
            Add(Country.PA, "6", "Herrera");
            Add(Country.PA, "7", "Los Santos");
            Add(Country.PA, "NT", "Naso Tjër Di");
            Add(Country.PA, "NB", "Ngäbe-Buglé");
            Add(Country.PA, "8", "Panamá");
            Add(Country.PA, "10", "Panamá Oeste");
            Add(Country.PA, "9", "Veraguas");

            Debug.Assert(_subdivisionsPerCountry[Country.PA].Count == 14, "Number of subdivisions is wrong.");
        }
    }
}
