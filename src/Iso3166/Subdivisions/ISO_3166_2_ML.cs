using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:ML is the entry for Mali in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Mali, ISO 3166-2 codes are defined for 1 district and 10 regions.The district Bamako is the capital of the country and has special status equal to the regions.
        /// Each code consists of two parts, separated by a hyphen.The first part is ML, the ISO 3166-1 alpha-2 code of Mali.The second part is either of the following:
        ///     three letters: district
        ///     1 or 2 digits(1–10) : regions
        /// The codes for the regions are assigned roughly from west to east.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:ML
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_ML()
        {
            Add(Country.ML, "BKO", "Bamako");
            Add(Country.ML, "7", "Gao");
            Add(Country.ML, "1", "Kayes");
            Add(Country.ML, "8", "Kidal");
            Add(Country.ML, "2", "Koulikoro");
            Add(Country.ML, "9", "Ménaka");
            Add(Country.ML, "5", "Mopti");
            Add(Country.ML, "4", "Ségou");
            Add(Country.ML, "3", "Sikasso");
            Add(Country.ML, "10", "Taoudénit");
            Add(Country.ML, "6", "Tombouctou");

            Debug.Assert(_subdivisionsPerCountry[Country.ML].Count == 11, $"{Country.ML} Number of subdivisions is wrong.");
        }
    }
}
