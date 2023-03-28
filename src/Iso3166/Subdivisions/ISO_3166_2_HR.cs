using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:HR is the entry for Croatia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Croatia, ISO 3166-2 codes are defined for 1 city and 20 counties.The city Zagreb is the capital of the country and has special status equal to the counties.
        /// Each code consists of two parts, separated by a hyphen.The first part is HR, the ISO 3166-1 alpha-2 code of Croatia.The second part is two digits:
        ///     01–20: counties
        ///     21: city
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:HR
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_HR()
        {
            Add(Country.HR, "21", "Zagreb City");
            Add(Country.HR, "07", "Bjelovar-Bilogora");
            Add(Country.HR, "12", "Brod-Posavina");
            Add(Country.HR, "19", "Dubrovnik-Neretva");
            Add(Country.HR, "18", "Istria");
            Add(Country.HR, "04", "Karlovac");
            Add(Country.HR, "06", "Koprivnica-Križevci");
            Add(Country.HR, "02", "Krapina-Zagorje");
            Add(Country.HR, "09", "Lika-Senj");
            Add(Country.HR, "20", "Međimurje");
            Add(Country.HR, "14", "Osijek-Baranja");
            Add(Country.HR, "11", "Požega-Slavonia");
            Add(Country.HR, "08", "Primorje-Gorski Kotar");
            Add(Country.HR, "03", "Sisak-Moslavina");
            Add(Country.HR, "17", "Split-Dalmatia");
            Add(Country.HR, "15", "Šibenik-Knin");
            Add(Country.HR, "05", "Varaždin");
            Add(Country.HR, "10", "Virovitica-Podravina");
            Add(Country.HR, "16", "Vukovar-Srijem");
            Add(Country.HR, "13", "Zadar");
            Add(Country.HR, "01", "Zagreb County");

            Debug.Assert(_subdivisionsPerCountry[Country.HR].Count == 21, $"{Country.HR} Number of subdivisions is wrong.");
        }
    }
}
