using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:NO is the entry for Norway in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently, for Norway, ISO 3166-2 codes are defined for the following subdivisions:
        ///     11 counties
        ///     2 arctic regions(i.e., Svalbard and Jan Mayen, territories in the Arctic region separated from metropolitan Norway)
        /// Each code consists of two parts, separated by a hyphen.The first part is NO, the ISO 3166-1 alpha-2 code of Norway.The second part is two digits.
        /// Collectively Svalbard and Jan Mayen is also assigned its own country code in ISO 3166-1, with alpha-2 code SJ.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:NO
        /// LastUpdated: 2023-03-16
        /// </remarks>
        internal static void ISO_3166_2_NO()
        {
            Add(Country.NO, "42", "Agder");
            Add(Country.NO, "34", "Innlandet");
            Add(Country.NO, "15", "Møre og Romsdal");
            Add(Country.NO, "18", "Nordland");
            Add(Country.NO, "03", "Oslo");
            Add(Country.NO, "11", "Rogaland");
            Add(Country.NO, "54", "Troms og Finnmark");
            Add(Country.NO, "50", "Trøndelag");
            Add(Country.NO, "38", "Vestfold og Telemark");
            Add(Country.NO, "46", "Vestland");
            Add(Country.NO, "30", "Viken");
            Add(Country.NO, "22", "Jan Mayen");
            Add(Country.NO, "21", "Svalbard");

            Debug.Assert(_subdivisionsPerCountry[Country.NO].Count == 13, "Number of subdivisions is wrong.");
        }
    }
}
