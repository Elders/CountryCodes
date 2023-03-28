using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:NZ is the entry for New Zealand in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166.
        /// Currently for New Zealand, ISO 3166-2 codes are defined for 16 regions and 1 special island authority
        /// Some New Zealand outlying islands that are outside the authority of any regions are not assigned codes, specifically:
        ///     Kermadec Islands
        ///     New Zealand Subantarctic Islands
        ///     Three Kings Islands
        /// Each code consists of two parts, separated by a hyphen.The first part is NZ, the ISO 3166-1 alpha-2 code of New Zealand.
        /// The second part is three letters: regions and special island authority.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:NZ
        /// LastUpdated: 2023-03-16
        /// </remarks>
        internal static void ISO_3166_2_NZ()
        {
            Add(Country.NZ, "AUK", "Auckland");
            Add(Country.NZ, "BOP", "Bay of Plenty");
            Add(Country.NZ, "CAN", "Canterbury");
            Add(Country.NZ, "CIT", "Chatham Islands Territory");
            Add(Country.NZ, "GIS", "Gisborne");
            Add(Country.NZ, "WGN", "Greater Wellington");
            Add(Country.NZ, "HKB", "Hawke's Bay");
            Add(Country.NZ, "MWT", "Manawatū-Whanganui");
            Add(Country.NZ, "MBH", "Marlborough");
            Add(Country.NZ, "NSN", "Nelson");
            Add(Country.NZ, "NTL", "Northland");
            Add(Country.NZ, "OTA", "Otago");
            Add(Country.NZ, "STL", "Southland");
            Add(Country.NZ, "TKI", "Taranaki");
            Add(Country.NZ, "TAS", "Tasman");
            Add(Country.NZ, "WKO", "Waikato");
            Add(Country.NZ, "WTC", "West Coast");

            Debug.Assert(_subdivisionsPerCountry[Country.NZ].Count == 17, $"{Country.NZ} Number of subdivisions is wrong.");
        }
    }
}
