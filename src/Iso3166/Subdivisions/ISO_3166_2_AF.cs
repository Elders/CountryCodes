using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:AF
        /// LastUpdated: 2023-03-17
        /// </remarks>
        internal static void ISO_3166_2_AF()
        {
            Add(Country.AF, "BDS", "Badakhshan");
            Add(Country.AF, "BGL", "Baghlan");
            Add(Country.AF, "BAL", "Balkh");
            Add(Country.AF, "BAM", "Bamyan");
            Add(Country.AF, "DAY", "Daykundi");
            Add(Country.AF, "FRA", "Farah");
            Add(Country.AF, "FYB", "Faryab");
            Add(Country.AF, "GHA", "Ghazni");
            Add(Country.AF, "GHO", "Ghor");
            Add(Country.AF, "HEL", "Helmand");
            Add(Country.AF, "HER", "Herat");
            Add(Country.AF, "JOW", "Jowzjan");
            Add(Country.AF, "KAB", "Kabul");
            Add(Country.AF, "KAN", "Kandahar");
            Add(Country.AF, "KAP", "Kapisa");
            Add(Country.AF, "KDZ", "Kunduz");
            Add(Country.AF, "KHO", "Khost");
            Add(Country.AF, "KNR", "Konar");
            Add(Country.AF, "LAG", "Laghman");
            Add(Country.AF, "LOG", "Logar");
            Add(Country.AF, "NAN", "Nangarhar");
            Add(Country.AF, "NIM", "Nimroz");
            Add(Country.AF, "NUR", "Nuristan");
            Add(Country.AF, "PAN", "Panjshir");
            Add(Country.AF, "PAR", "Parwan");
            Add(Country.AF, "PIA", "Paktia");
            Add(Country.AF, "PKA", "Paktika");
            Add(Country.AF, "SAM", "Samangan");
            Add(Country.AF, "SAR", "Sar-e Pol");
            Add(Country.AF, "TAK", "Takhar");
            Add(Country.AF, "URU", "Uruzgan");
            Add(Country.AF, "WAR", "Wardak");
            Add(Country.AF, "ZAB", "Zabul");

            Debug.Assert(_subdivisionsPerCountry[Country.AF].Count == 33, $"{Country.AF} Number of subdivisions is wrong.");
        }
    }
}
