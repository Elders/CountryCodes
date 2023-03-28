using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:VN is the entry for Vietnam in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Vietnam, ISO 3166-2 codes are defined for 58 provinces and 5 municipalities.The municipalities have special status equal to the provinces.
        /// Each code consists of two parts, separated by a hyphen.The first part is VN, the ISO 3166-1 alpha-2 code of Vietnam.The second part either of the following:
        ///    two digits: provinces
        ///    two letters: municipalities
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:VN
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_VN()
        {
            Add(Country.VN, "44", "An Giang");
            Add(Country.VN, "43", "Bà Rịa - Vũng Tàu");
            Add(Country.VN, "54", "Bắc Giang");
            Add(Country.VN, "53", "Bắc Kạn");
            Add(Country.VN, "55", "Bạc Liêu");
            Add(Country.VN, "56", "Bắc Ninh");
            Add(Country.VN, "50", "Bến Tre");
            Add(Country.VN, "31", "Bình Định");
            Add(Country.VN, "57", "Bình Dương");
            Add(Country.VN, "58", "Bình Phước");
            Add(Country.VN, "40", "Bình Thuận");
            Add(Country.VN, "59", "Cà Mau");
            Add(Country.VN, "04", "Cao Bằng");
            Add(Country.VN, "33", "Đắk Lắk");
            Add(Country.VN, "72", "Đắk Nông");
            Add(Country.VN, "71", "Điện Biên");
            Add(Country.VN, "39", "Đồng Nai");
            Add(Country.VN, "45", "Đồng Tháp");
            Add(Country.VN, "30", "Gia Lai");
            Add(Country.VN, "03", "Hà Giang");
            Add(Country.VN, "63", "Hà Nam");
            Add(Country.VN, "23", "Hà Tĩnh");
            Add(Country.VN, "61", "Hải Dương");
            Add(Country.VN, "73", "Hậu Giang");
            Add(Country.VN, "14", "Hòa Bình");
            Add(Country.VN, "66", "Hưng Yên");
            Add(Country.VN, "34", "Khánh Hòa");
            Add(Country.VN, "47", "Kiến Giang");
            Add(Country.VN, "28", "Kon Tum");
            Add(Country.VN, "01", "Lai Châu");
            Add(Country.VN, "35", "Lâm Đồng");
            Add(Country.VN, "09", "Lạng Sơn");
            Add(Country.VN, "02", "Lào Cai");
            Add(Country.VN, "41", "Long An");
            Add(Country.VN, "67", "Nam Định");
            Add(Country.VN, "22", "Nghệ An");
            Add(Country.VN, "18", "Ninh Bình");
            Add(Country.VN, "36", "Ninh Thuận");
            Add(Country.VN, "68", "Phú Thọ");
            Add(Country.VN, "32", "Phú Yên");
            Add(Country.VN, "24", "Quảng Bình");
            Add(Country.VN, "27", "Quảng Nam");
            Add(Country.VN, "29", "Quảng Ngãi");
            Add(Country.VN, "13", "Quảng Ninh");
            Add(Country.VN, "25", "Quảng Trị");
            Add(Country.VN, "52", "Sóc Trăng");
            Add(Country.VN, "05", "Sơn La");
            Add(Country.VN, "37", "Tây Ninh");
            Add(Country.VN, "20", "Thái Bình");
            Add(Country.VN, "69", "Thái Nguyên");
            Add(Country.VN, "21", "Thanh Hóa");
            Add(Country.VN, "26", "Thừa Thiên-Huế");
            Add(Country.VN, "46", "Tiền Giang");
            Add(Country.VN, "51", "Trà Vinh");
            Add(Country.VN, "07", "Tuyên Quang");
            Add(Country.VN, "49", "Vĩnh Long");
            Add(Country.VN, "70", "Vĩnh Phúc");
            Add(Country.VN, "06", "Yên Bái");
            Add(Country.VN, "CT", "Cần Thơ");
            Add(Country.VN, "DN", "Đà Nẵng");
            Add(Country.VN, "HN", "Hà Nội");
            Add(Country.VN, "HP", "Hải Phòng");
            Add(Country.VN, "SG", "Hồ Chí Minh");

            Debug.Assert(_subdivisionsPerCountry[Country.VN].Count == 63, $"{Country.VN} Number of subdivisions is wrong.");
        }
    }
}
