using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:GT is the entry for Guatemala in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Guatemala, ISO 3166-2 codes are defined for 22 departments.
        /// Each code consists of two parts, separated by a hyphen.The first part is GT, the ISO 3166-1 alpha-2 code of Guatemala.The second part is two digits.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:GT
        /// LastUpdated: 2023-03-23
        /// </remarks>
        internal static void ISO_3166_2_GT()
        {
            Add(Country.GT, "16", "Alta Verapaz");
            Add(Country.GT, "15", "Baja Verapaz");
            Add(Country.GT, "04", "Chimaltenango");
            Add(Country.GT, "20", "Chiquimula");
            Add(Country.GT, "02", "El Progreso");
            Add(Country.GT, "05", "Escuintla");
            Add(Country.GT, "01", "Guatemala");
            Add(Country.GT, "13", "Huehuetenango");
            Add(Country.GT, "18", "Izabal");
            Add(Country.GT, "21", "Jalapa");
            Add(Country.GT, "22", "Jutiapa");
            Add(Country.GT, "17", "Petén");
            Add(Country.GT, "09", "Quetzaltenango");
            Add(Country.GT, "14", "Quiché");
            Add(Country.GT, "11", "Retalhuleu");
            Add(Country.GT, "03", "Sacatepéquez");
            Add(Country.GT, "12", "San Marcos");
            Add(Country.GT, "06", "Santa Rosa");
            Add(Country.GT, "07", "Sololá");
            Add(Country.GT, "10", "Suchitepéquez");
            Add(Country.GT, "08", "Totonicapán");
            Add(Country.GT, "19", "Zacapa");

            Debug.Assert(_subdivisionsPerCountry[Country.GT].Count == 22, $"{Country.GT} Number of subdivisions is wrong.");
        }
    }
}
