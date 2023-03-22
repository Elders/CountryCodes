using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:RO is the entry for Romania in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Romania, ISO 3166-2 codes are defined for 41 departments and 1 municipality.The municipality Bucharest is the capital of the country and has special status equal to the departments.
        /// Each code consists of two parts, separated by a hyphen.The first part is RO, the ISO 3166-1 alpha-2 code of Romania.The second part is either of the following:
        ///     one letter: municipality
        ///     two letters: departments
        /// The letters are currently used in vehicle registration plates.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:RO
        /// LastUpdated: 2023-03-21
        /// </remarks>
        internal static void ISO_3166_2_RO()
        {
            Add(Country.RO, "AB", "Alba");
            Add(Country.RO, "AR", "Arad");
            Add(Country.RO, "AG", "Argeș");
            Add(Country.RO, "BC", "Bacău");
            Add(Country.RO, "BH", "Bihor");
            Add(Country.RO, "BN", "Bistrița-Năsăud");
            Add(Country.RO, "BT", "Botoșani");
            Add(Country.RO, "BV", "Brașov");
            Add(Country.RO, "BR", "Brăila");
            Add(Country.RO, "BZ", "Buzău");
            Add(Country.RO, "CS", "Caraș-Severin");
            Add(Country.RO, "CL", "Călărași");
            Add(Country.RO, "CJ", "Cluj");
            Add(Country.RO, "CT", "Constanța");
            Add(Country.RO, "CV", "Covasna");
            Add(Country.RO, "DB", "Dâmbovița");
            Add(Country.RO, "DJ", "Dolj");
            Add(Country.RO, "GL", "Galați");
            Add(Country.RO, "GR", "Giurgiu");
            Add(Country.RO, "GJ", "Gorj");
            Add(Country.RO, "HR", "Harghita");
            Add(Country.RO, "HD", "Hunedoara");
            Add(Country.RO, "IL", "Ialomița");
            Add(Country.RO, "IS", "Iași");
            Add(Country.RO, "IF", "Ilfov");
            Add(Country.RO, "MM", "Maramureș");
            Add(Country.RO, "MH", "Mehedinți");
            Add(Country.RO, "MS", "Mureș");
            Add(Country.RO, "NT", "Neamț");
            Add(Country.RO, "OT", "Olt");
            Add(Country.RO, "PH", "Prahova");
            Add(Country.RO, "SM", "Satu Mare");
            Add(Country.RO, "SJ", "Sălaj");
            Add(Country.RO, "SB", "Sibiu");
            Add(Country.RO, "SV", "Suceava");
            Add(Country.RO, "TR", "Teleorman");
            Add(Country.RO, "TM", "Timiș");
            Add(Country.RO, "TL", "Tulcea");
            Add(Country.RO, "VS", "Vaslui");
            Add(Country.RO, "VL", "Vâlcea");
            Add(Country.RO, "VN", "Vrancea");
            Add(Country.RO, "B", "București");

            Debug.Assert(_subdivisionsPerCountry[Country.RO].Count == 42, "Number of subdivisions is wrong.");
        }
    }
}
