using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MV is the entry for Maldives in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Maldives, ISO 3166-2 codes are defined for two cities and 19 administrative atolls.
        /// Each code consists of two parts, separated by a hyphen. The first part is MV, the ISO 3166-1 alpha-2 code of Maldives.The second part is one of the following:
        ///         three letters: Malé
        ///         two digits: Addu City and administrative atolls
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MV
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MV()
        {
            Add(Country.MV, "MLE", "Male");
            Add(Country.MV, "01", "Addu City");
            Add(Country.MV, "02", "North Ari Atoll");
            Add(Country.MV, "00", "South Ari Atoll");
            Add(Country.MV, "20", "South Maalhosmadulu");
            Add(Country.MV, "17", "South Nilandhe Atoll");
            Add(Country.MV, "14", "North Nilandhe Atoll");
            Add(Country.MV, "27", "North Huvadhu Atoll");
            Add(Country.MV, "28", "South Huvadhu Atoll");
            Add(Country.MV, "29", "Fuvammulah");
            Add(Country.MV, "07", "North Thiladhunmathi");
            Add(Country.MV, "23", "South Thiladhunmathi");
            Add(Country.MV, "26", "Male Atoll");
            Add(Country.MV, "05", "Hahdhunmathi");
            Add(Country.MV, "03", "Faadhippolhu");
            Add(Country.MV, "12", "Mulaku Atoll");
            Add(Country.MV, "25", "South Miladhunmadulu");
            Add(Country.MV, "13", "North Maalhosmadulu");
            Add(Country.MV, "24", "North Miladhunmadulu");
            Add(Country.MV, "08", "Kolhumadulu");
            Add(Country.MV, "04", "Felidhu Atoll");

            Debug.Assert(_subdivisionsPerCountry[Country.MV].Count == 21, $"{Country.MV} Number of subdivisions is wrong.");
        }
    }
}
