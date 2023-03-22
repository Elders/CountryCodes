using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:MD is the entry for Moldova in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Moldova, ISO 3166-2 codes are defined for 1 autonomous territorial unit, 3 cities, 32 districts, and 1 territorial unit.The three cities have special status equal to the districts.
        /// Each code consists of two parts, separated by a hyphen. The first part is MD, the ISO 3166-1 alpha-2 code of Moldova.The second part is two letters.
        /// Due to limited international recognition, Transnistria is considered part of Moldova and does not have its own ISO 3166-1 code.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:MD
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_MD()
        {
            Add(Country.MD, "GA", "Găgăuzia");
            Add(Country.MD, "BA", "Bălți");
            Add(Country.MD, "BD", "Bender");
            Add(Country.MD, "CU", "Chișinău");
            Add(Country.MD, "AN", "Anenii Noi");
            Add(Country.MD, "BS", "Basarabeasca");
            Add(Country.MD, "BR", "Briceni");
            Add(Country.MD, "CA", "Cahul");
            Add(Country.MD, "CT", "Cantemir");
            Add(Country.MD, "CL", "Călărași");
            Add(Country.MD, "CS", "Căușeni");
            Add(Country.MD, "CM", "Cimișlia");
            Add(Country.MD, "CR", "Criuleni");
            Add(Country.MD, "DO", "Dondușeni");
            Add(Country.MD, "DR", "Drochia");
            Add(Country.MD, "DU", "Dubăsari");
            Add(Country.MD, "ED", "Edineț");
            Add(Country.MD, "FA", "Fălești");
            Add(Country.MD, "FL", "Florești");
            Add(Country.MD, "GL", "Glodeni");
            Add(Country.MD, "HI", "Hîncești");
            Add(Country.MD, "IA", "Ialoveni");
            Add(Country.MD, "LE", "Leova");
            Add(Country.MD, "NI", "Nisporeni");
            Add(Country.MD, "OC", "Ocnița");
            Add(Country.MD, "OR", "Orhei");
            Add(Country.MD, "RE", "Rezina");
            Add(Country.MD, "RI", "Rîșcani");
            Add(Country.MD, "SI", "Sîngerei");
            Add(Country.MD, "SO", "Soroca");
            Add(Country.MD, "ST", "Strășeni");
            Add(Country.MD, "SD", "Șoldănești");
            Add(Country.MD, "SV", "Ștefan Vodă");
            Add(Country.MD, "TA", "Taraclia");
            Add(Country.MD, "TE", "Telenești");
            Add(Country.MD, "UN", "Ungheni");
            Add(Country.MD, "SN", "Stînga Nistrului");

            Debug.Assert(_subdivisionsPerCountry[Country.MD].Count == 37, "Number of subdivisions is wrong.");
        }
    }
}
