using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:PY is the entry for Paraguay in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO), which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Paraguay, ISO 3166-2 codes are defined for 1 capital and 17 departments.The capital of the country Asunción has special status equal to the departments.
        /// Each code consists of two parts, separated by a hyphen.The first part is PY, the ISO 3166-1 alpha-2 code of Paraguay.The second part is either of the following:
        ///     one or two digits(1–16, 19): departments
        ///     three letters: capital district
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:PY
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_PY()
        {
            Add(Country.PY, "ASU", "Asunción");
            Add(Country.PY, "16", "Alto Paraguay");
            Add(Country.PY, "10", "Alto Paraná");
            Add(Country.PY, "13", "Amambay");
            Add(Country.PY, "19", "Boquerón");
            Add(Country.PY, "5", "Caaguazú");
            Add(Country.PY, "6", "Caazapá");
            Add(Country.PY, "14", "Canindeyú");
            Add(Country.PY, "11", "Central");
            Add(Country.PY, "1", "Concepción");
            Add(Country.PY, "3", "Cordillera");
            Add(Country.PY, "4", "Guairá");
            Add(Country.PY, "7", "Itapúa");
            Add(Country.PY, "8", "Misiones");
            Add(Country.PY, "12", "Ñeembucú");
            Add(Country.PY, "9", "Paraguarí");
            Add(Country.PY, "15", "Presidente Hayes");
            Add(Country.PY, "2", "San Pedro");

            Debug.Assert(_subdivisionsPerCountry[Country.PY].Count == 18, "Number of subdivisions is wrong.");
        }
    }
}
