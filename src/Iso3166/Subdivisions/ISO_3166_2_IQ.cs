using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:IQ is the entry for Iraq in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Iraq, ISO 3166-2 codes are defined for 18 governorates and 1 region.
        /// Each code consists of two parts, separated by a hyphen.The first part is IQ, the ISO 3166-1 alpha-2 code of Iraq.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:IQ
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_IQ()
        {
            Add(Country.IQ, "AN", "Al Anbār");
            Add(Country.IQ, "BA", "Al Başrah");
            Add(Country.IQ, "MU", "Al Muthanná");
            Add(Country.IQ, "QA", "Al Qādisīyah");
            Add(Country.IQ, "NA", "An Najaf");
            Add(Country.IQ, "AR", "Arbīl");
            Add(Country.IQ, "SU", "As Sulaymānīyah");
            Add(Country.IQ, "BB", "Bābil");
            Add(Country.IQ, "BG", "Baghdād");
            Add(Country.IQ, "DA", "Dahūk");
            Add(Country.IQ, "DQ", "Dhī Qār");
            Add(Country.IQ, "DI", "Diyālá");
            Add(Country.IQ, "KR", "Iqlīm Kūrdistān");
            Add(Country.IQ, "KA", "Karbalā’");
            Add(Country.IQ, "KI", "Kirkūk");
            Add(Country.IQ, "MA", "Maysān");
            Add(Country.IQ, "NI", "Nīnawá");
            Add(Country.IQ, "SD", "Şalāḩ ad Dīn");
            Add(Country.IQ, "WA", "Wāsiţ");

            Debug.Assert(_subdivisionsPerCountry[Country.IQ].Count == 19, "Number of subdivisions is wrong.");
        }
    }
}
