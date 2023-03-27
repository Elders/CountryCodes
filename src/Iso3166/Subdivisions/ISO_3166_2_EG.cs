using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:EG is the entry for Egypt in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Egypt, ISO 3166-2 codes are defined for 27 governorates. 6th of October Governorate and Helwan Governorate, which had their codes added in Newsletter II-2,
        /// were merged back into Giza Governorate and Cairo Governorate respectively in 2011.
        /// Each code consists of two parts, separated by a hyphen.The first part is EG, the ISO 3166-1 alpha-2 code of Egypt.The second part is either one, two, or three letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:EG
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_EG()
        {
            Add(Country.EG, "DK", "Dakahlia");
            Add(Country.EG, "BA", "Red Sea");
            Add(Country.EG, "BH", "Beheira");
            Add(Country.EG, "FYM", "Faiyum");
            Add(Country.EG, "GH", "Gharbia");
            Add(Country.EG, "ALX", "Alexandria");
            Add(Country.EG, "IS", "Ismailia");
            Add(Country.EG, "GZ", "Giza");
            Add(Country.EG, "MNF", "Monufia");
            Add(Country.EG, "MN", "Minya");
            Add(Country.EG, "C", "Cairo");
            Add(Country.EG, "KB", "Qalyubia");
            Add(Country.EG, "LX", "Luxor");
            Add(Country.EG, "WAD", "New Valley");
            Add(Country.EG, "SUZ", "Suez");
            Add(Country.EG, "SHR", "Al Sharqia");
            Add(Country.EG, "ASN", "Aswan");
            Add(Country.EG, "AST", "Asyut");
            Add(Country.EG, "BNS", "Beni Suef");
            Add(Country.EG, "PTS", "Port Said");
            Add(Country.EG, "DT", "Damietta");
            Add(Country.EG, "JS", "South Sinai");
            Add(Country.EG, "KFS", "Kafr el-Sheikh");
            Add(Country.EG, "MT", "Matrouh");
            Add(Country.EG, "KN", "Qena");
            Add(Country.EG, "SIN", "North Sinai");
            Add(Country.EG, "SHG", "Sohag");

            Debug.Assert(_subdivisionsPerCountry[Country.EG].Count == 27, "Number of subdivisions is wrong.");
        }
    }
}
