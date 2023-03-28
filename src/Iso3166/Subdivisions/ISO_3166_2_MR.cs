using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MR is the entry for Mauritania in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Mauritania, ISO 3166-2 codes are defined for 15 regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is MR,
        /// the ISO 3166-1 alpha-2 code of Mauritania.The second part is two digits(01–15) for the regions.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MR
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MR()
        {
            Add(Country.MR, "07", "Adrar");
            Add(Country.MR, "03", "Assaba");
            Add(Country.MR, "05", "Brakna");
            Add(Country.MR, "08", "Dakhlet Nouâdhibou");
            Add(Country.MR, "04", "Gorgol");
            Add(Country.MR, "10", "Guidimaka");
            Add(Country.MR, "01", "Hodh ech Chargui");
            Add(Country.MR, "02", "Hodh el Gharbi");
            Add(Country.MR, "12", "Inchiri");
            Add(Country.MR, "14", "Nouakchott Nord");
            Add(Country.MR, "13", "Nouakchott Ouest");
            Add(Country.MR, "15", "Nouakchott Sud");
            Add(Country.MR, "09", "Tagant");
            Add(Country.MR, "11", "Tiris Zemmour");
            Add(Country.MR, "06", "Trarza");

            Debug.Assert(_subdivisionsPerCountry[Country.MR].Count == 15, $"{Country.MR} Number of subdivisions is wrong.");
        }
    }
}
