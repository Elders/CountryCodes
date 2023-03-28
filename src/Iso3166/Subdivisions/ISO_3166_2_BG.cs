using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:BG is the entry for Bulgaria in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO), which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Bulgaria, ISO 3166-2 codes are defined for 28 districts.
        /// Each code consists of two parts, separated by a hyphen. The first part is BG, the ISO 3166-1 alpha-2 code of Bulgaria. The second part is two digits (01–28). The codes are assigned in Bulgarian alphabetical order.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BG
        /// LastUpdated: 2023-03-15
        /// </remarks>
        internal static void ISO_3166_2_BG()
        {
            Add(Country.BG, "01", "Blagoevgrad");
            Add(Country.BG, "02", "Burgas");
            Add(Country.BG, "08", "Dobrich");
            Add(Country.BG, "07", "Gabrovo");
            Add(Country.BG, "26", "Haskovo");
            Add(Country.BG, "09", "Kardzhali");
            Add(Country.BG, "10", "Kyustendil");
            Add(Country.BG, "11", "Lovech");
            Add(Country.BG, "12", "Montana");
            Add(Country.BG, "13", "Pazardzhik");
            Add(Country.BG, "14", "Pernik");
            Add(Country.BG, "15", "Pleven");
            Add(Country.BG, "16", "Plovdiv");
            Add(Country.BG, "17", "Razgrad");
            Add(Country.BG, "18", "Ruse");
            Add(Country.BG, "27", "Shumen");
            Add(Country.BG, "19", "Silistra");
            Add(Country.BG, "20", "Sliven");
            Add(Country.BG, "21", "Smolyan");
            Add(Country.BG, "23", "Sofia");
            Add(Country.BG, "22", "Sofia (stolitsa)");
            Add(Country.BG, "24", "Stara Zagora");
            Add(Country.BG, "25", "Targovishte");
            Add(Country.BG, "03", "Varna");
            Add(Country.BG, "04", "Veliko Tarnovo");
            Add(Country.BG, "05", "Vidin");
            Add(Country.BG, "06", "Vratsa");
            Add(Country.BG, "28", "Yambol");

            Debug.Assert(_subdivisionsPerCountry[Country.BG].Count == 28, $"{Country.BG} Number of subdivisions is wrong.");
        }
    }
}
