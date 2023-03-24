using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:LV is the entry for Latvia in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Latvia, ISO 3166-2 codes are defined for 36 municipalities and 7 state cities.The seven state cities have special status equal to the municipalities.
        /// Each code consists of two parts, separated by a hyphen. The first part is LV, the ISO 3166-1 alpha-2 code of Latvia.The second part is either of the following:
        ///     three digits: municipalities
        ///     three letters: state cities
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:LV
        /// LastUpdated: 2023-03-24
        /// </remarks>
        internal static void ISO_3166_2_LV()
        {
            Add(Country.LV, "002", "Aizkraukles novads");
            Add(Country.LV, "007", "Alūksnes novads");
            Add(Country.LV, "011", "Ādažu novads");
            Add(Country.LV, "015", "Balvu novads");
            Add(Country.LV, "016", "Bauskas novads");
            Add(Country.LV, "022", "Cēsu novads");
            Add(Country.LV, "026", "Dobeles novads");
            Add(Country.LV, "033", "Gulbenes novads");
            Add(Country.LV, "041", "Jelgavas novads");
            Add(Country.LV, "042", "Jēkabpils novads");
            Add(Country.LV, "047", "Krāslavas novads");
            Add(Country.LV, "050", "Kuldīgas novads");
            Add(Country.LV, "052", "Ķekavas novads");
            Add(Country.LV, "054", "Limbažu novads");
            Add(Country.LV, "056", "Līvānu novads");
            Add(Country.LV, "058", "Ludzas novads");
            Add(Country.LV, "059", "Madonas novads");
            Add(Country.LV, "062", "Mārupes novads");
            Add(Country.LV, "067", "Ogres novads");
            Add(Country.LV, "068", "Olaines novads");
            Add(Country.LV, "073", "Preiļu novads");
            Add(Country.LV, "077", "Rēzeknes novads");
            Add(Country.LV, "080", "Ropažu novads");
            Add(Country.LV, "087", "Salaspils novads");
            Add(Country.LV, "088", "Saldus novads");
            Add(Country.LV, "089", "Saulkrastu novads");
            Add(Country.LV, "091", "Siguldas novads");
            Add(Country.LV, "094", "Smiltenes novads");
            Add(Country.LV, "097", "Talsu novads");
            Add(Country.LV, "099", "Tukuma novads");
            Add(Country.LV, "101", "Valkas novads");
            Add(Country.LV, "102", "Varakļānu novads");
            Add(Country.LV, "106", "Ventspils novads");
            Add(Country.LV, "111", "Augšdaugavas novads");
            Add(Country.LV, "112", "Dienvidkurzemes Novads");
            Add(Country.LV, "113", "Valmieras Novads");
            Add(Country.LV, "DGV", "Daugavpils");
            Add(Country.LV, "JEL", "Jelgava");
            Add(Country.LV, "JUR", "Jūrmala");
            Add(Country.LV, "LPX", "Liepāja");
            Add(Country.LV, "REZ", "Rēzekne");
            Add(Country.LV, "RIX", "Rīga");
            Add(Country.LV, "VEN", "Ventspils");

            Debug.Assert(_subdivisionsPerCountry[Country.LV].Count == 43, "Number of subdivisions is wrong.");
        }
    }
}
