using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SM is the entry for San Marino in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for San Marino, ISO 3166-2 codes are defined for 9 municipalities.
        /// Each code consists of two parts, separated by a hyphen.The first part is SM, the ISO 3166-1 alpha-2 code of San Marino.The second part is two digits (01–09).
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SM
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_SM()
        {
            Add(Country.SM, "01", "Acquaviva");
            Add(Country.SM, "06", "Borgo Maggiore");
            Add(Country.SM, "02", "Chiesanuova");
            Add(Country.SM, "07", "Città di San Marino");
            Add(Country.SM, "03", "Domagnano");
            Add(Country.SM, "04", "Faetano");
            Add(Country.SM, "05", "Fiorentino");
            Add(Country.SM, "08", "Montegiardino");
            Add(Country.SM, "09", "Serravalle");

            Debug.Assert(_subdivisionsPerCountry[Country.SM].Count == 9, "Number of subdivisions is wrong.");
        }
    }
}
