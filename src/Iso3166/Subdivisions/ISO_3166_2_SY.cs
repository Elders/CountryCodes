using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SY is the entry for Syria in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Syria, ISO 3166-2 codes are defined for 14 provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is SY, the ISO 3166-1 alpha-2 code of Syria.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SY
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_SY()
        {
            Add(Country.SY, "HA", "Al Ḩasakah");
            Add(Country.SY, "LA", "Al Lādhiqīyah");
            Add(Country.SY, "QU", "Al Qunayţirah");
            Add(Country.SY, "RA", "Ar Raqqah");
            Add(Country.SY, "SU", "As Suwaydā'");
            Add(Country.SY, "DR", "Dar'ā");
            Add(Country.SY, "DY", "Dayr az Zawr");
            Add(Country.SY, "DI", "Dimashq");
            Add(Country.SY, "HL", "Ḩalab");
            Add(Country.SY, "HM", "Ḩamāh");
            Add(Country.SY, "HI", "Ḩimş");
            Add(Country.SY, "ID", "Idlib");
            Add(Country.SY, "RD", "Rīf Dimashq");
            Add(Country.SY, "TA", "Ţarţūs");

            Debug.Assert(_subdivisionsPerCountry[Country.SY].Count == 14, $"{Country.SY} Number of subdivisions is wrong.");
        }
    }
}
