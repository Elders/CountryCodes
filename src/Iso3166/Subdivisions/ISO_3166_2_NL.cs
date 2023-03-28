using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:NL is the entry for the Kingdom of the Netherlands in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for the kingdom, ISO 3166-2 codes are defined for 3 countries, 12 provinces and 3 special municipalities.
        /// The kingdom consists of the 3 countries + the country of the Netherlands which is composed of the provinces and the special municipalities.
        /// Each code consists of two parts, separated by a hyphen. The first part is NL, the ISO 3166-1 alpha-2 code of the Netherlands. The second part either of the following:
        ///     two letters: provinces or countries
        ///     two letters and a digit: special municipalities
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:NL
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_NL()
        {
            Add(Country.NL, "DR", "Drenthe");
            Add(Country.NL, "FL", "Flevoland");
            Add(Country.NL, "FR", "Friesland");
            Add(Country.NL, "GE", "Gelderland");
            Add(Country.NL, "GR", "Groningen");
            Add(Country.NL, "LI", "Limburg");
            Add(Country.NL, "NB", "North Brabant");
            Add(Country.NL, "NH", "North Holland");
            Add(Country.NL, "OV", "Overijssel");
            Add(Country.NL, "UT", "Utrecht");
            Add(Country.NL, "ZE", "Zeeland");
            Add(Country.NL, "ZH", "South Holland");

            Debug.Assert(_subdivisionsPerCountry[Country.NL].Count == 12, $"{Country.NL} Number of subdivisions is wrong.");
        }
    }
}
