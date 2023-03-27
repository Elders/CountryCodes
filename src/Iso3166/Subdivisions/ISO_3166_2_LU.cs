using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:LU is the entry for Luxembourg in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Luxembourg, ISO 3166-2 codes are defined for 12 cantons.
        /// Each code consists of two parts, separated by a hyphen.The first part is LU, the ISO 3166-1 alpha-2 code of Luxembourg.The second part is a letter.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:LU
        /// LastUpdated: 2023-03-16
        /// </remarks>
        internal static void ISO_3166_2_LU()
        {
            Add(Country.LU, "CA", "Capellen");
            Add(Country.LU, "CL", "Clerf");
            Add(Country.LU, "DI", "Diekirch");
            Add(Country.LU, "EC", "Echternach");
            Add(Country.LU, "ES", "Esch an der Alzette");
            Add(Country.LU, "GR", "Grevenmacher");
            Add(Country.LU, "LU", "Luxemburg");
            Add(Country.LU, "ME", "Mersch");
            Add(Country.LU, "RD", "Redingen");
            Add(Country.LU, "RM", "Remich");
            Add(Country.LU, "VD", "Vianden");
            Add(Country.LU, "WI", "Wiltz");
            Add(Country.LU, "D", "Diekirch");
            Add(Country.LU, "G", "Grevenmacher");
            Add(Country.LU, "L", "Luxemburg");

            Debug.Assert(_subdivisionsPerCountry[Country.LU].Count == 15, "Number of subdivisions is wrong.");
        }
    }
}
