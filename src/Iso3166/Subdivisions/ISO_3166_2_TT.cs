using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:TT is the entry for Trinidad and Tobago in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Trinidad and Tobago, ISO 3166-2 codes are defined for 9 regions, 3 boroughs, 2 cities, and 1 ward.
        /// Each code consists of two parts
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:TT
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_TT()
        {
            Add(Country.TT, "ARI", "Arima");
            Add(Country.TT, "CHA", "Chaguanas");
            Add(Country.TT, "CTT", "Couva-Tabaquite-Talparo");
            Add(Country.TT, "DMN", "Diego Martin");
            Add(Country.TT, "MRC", "Mayaro-Rio Claro");
            Add(Country.TT, "PED", "Penal-Debe");
            Add(Country.TT, "POS", "Port of Spain");
            Add(Country.TT, "PRT", "Princes Town");
            Add(Country.TT, "PTF", "Point Fortin");
            Add(Country.TT, "SFO", "San Fernando");
            Add(Country.TT, "SGE", "Sangre Grande");
            Add(Country.TT, "SIP", "Siparia");
            Add(Country.TT, "SJL", "San Juan-Laventille");
            Add(Country.TT, "TOB", "Tobago");
            Add(Country.TT, "TUP", "Tunapuna-Piarco");

            Debug.Assert(_subdivisionsPerCountry[Country.TT].Count == 15, $"{Country.TT} Number of subdivisions is wrong.");
        }
    }
}
