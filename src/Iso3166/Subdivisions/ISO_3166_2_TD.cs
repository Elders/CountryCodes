using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:TD is the entry for Chad in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Chad, ISO 3166-2 codes are defined for 23 provinces(mintaqah[1]).
        /// Each code consists of two parts, separated by a hyphen.The first part is TD, the ISO 3166-1 alpha-2 code of Chad.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:TD
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_TD()
        {
            Add(Country.TD, "BA", "Batha");
            Add(Country.TD, "LC", "Lac");
            Add(Country.TD, "BG", "Bahr el Ghazal");
            Add(Country.TD, "BO", "Borkou");
            Add(Country.TD, "HL", "Hadjer Lamis");
            Add(Country.TD, "EO", "Ennedi-Ouest");
            Add(Country.TD, "EE", "Ennedi-Est");
            Add(Country.TD, "KA", "Kanem");
            Add(Country.TD, "LO", "Logone-Occidental");
            Add(Country.TD, "LR", "Logone-Oriental");
            Add(Country.TD, "ND", "Ville de Ndjamena");
            Add(Country.TD, "MA", "Mandoul");
            Add(Country.TD, "MO", "Mayo-Kebbi-Ouest");
            Add(Country.TD, "ME", "Mayo-Kebbi-Est");
            Add(Country.TD, "GR", "Guéra");
            Add(Country.TD, "SA", "Salamat");
            Add(Country.TD, "MC", "Moyen-Chari");
            Add(Country.TD, "CB", "Chari-Baguirmi");
            Add(Country.TD, "SI", "Sila");
            Add(Country.TD, "TA", "Tandjilé");
            Add(Country.TD, "TI", "Tibesti");
            Add(Country.TD, "OD", "Ouaddaï");
            Add(Country.TD, "WF", "Wadi Fira");

            Debug.Assert(_subdivisionsPerCountry[Country.TD].Count == 23, $"{Country.TD} Number of subdivisions is wrong.");
        }
    }
}
