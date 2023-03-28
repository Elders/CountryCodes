using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:TH is the entry for Thailand in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Thailand, ISO 3166-2 codes are defined for 1 metropolitan administration, 1 special administrative city, and 76 provinces.
        /// The metropolitan administration Bangkok is the capital of the country and has special status equal to the provinces.The special administrative city Pattaya is a self-governing city in Chonburi province.
        /// Each code consists of two parts, separated by a hyphen. The first part is TH, the ISO 3166-1 alpha-2 code of Thailand.The second part is two digits, except Pattaya which uses a letter:
        ///    leading digits 1, 2, 6, 7: Central Thailand
        ///    leading digits 3, 4: Northeastern Thailand
        ///    leading digit 5: Northern Thailand
        ///    leading digits 8, 9: Southern Thailand
        ///    S: Pattaya
        /// ISO 3166-2:TH follows the Thai standard TIS 1099, which in turn follows codes assigned by the Ministry of Interior.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:TH
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_TH()
        {
            Add(Country.TH, "37", "Amnat Charoen");
            Add(Country.TH, "15", "Ang Thong");
            Add(Country.TH, "38", "Bueng Kan");
            Add(Country.TH, "31", "Buri Ram");
            Add(Country.TH, "24", "Chachoengsao");
            Add(Country.TH, "18", "Chai Nat");
            Add(Country.TH, "36", "Chaiyaphum");
            Add(Country.TH, "22", "Chanthaburi");
            Add(Country.TH, "50", "Chiang Mai");
            Add(Country.TH, "57", "Chiang Rai");
            Add(Country.TH, "20", "Chon Buri");
            Add(Country.TH, "86", "Chumphon");
            Add(Country.TH, "46", "Kalasin");
            Add(Country.TH, "62", "Kamphaeng Phet");
            Add(Country.TH, "71", "Kanchanaburi");
            Add(Country.TH, "40", "Khon Kaen");
            Add(Country.TH, "81", "Krabi");
            Add(Country.TH, "10", "Krung Thep Maha Nakhon");
            Add(Country.TH, "52", "Lampang");
            Add(Country.TH, "51", "Lamphun");
            Add(Country.TH, "42", "Loei");
            Add(Country.TH, "16", "Lop Buri");
            Add(Country.TH, "58", "Mae Hong Son");
            Add(Country.TH, "44", "Maha Sarakham");
            Add(Country.TH, "49", "Mukdahan");
            Add(Country.TH, "26", "Nakhon Nayok");
            Add(Country.TH, "73", "Nakhon Pathom");
            Add(Country.TH, "48", "Nakhon Phanom");
            Add(Country.TH, "30", "Nakhon Ratchasima");
            Add(Country.TH, "60", "Nakhon Sawan");
            Add(Country.TH, "80", "Nakhon Si Thammarat");
            Add(Country.TH, "55", "Nan");
            Add(Country.TH, "96", "Narathiwat");
            Add(Country.TH, "39", "Nong Bua Lam Phu");
            Add(Country.TH, "43", "Nong Khai");
            Add(Country.TH, "12", "Nonthaburi");
            Add(Country.TH, "13", "Pathum Thani");
            Add(Country.TH, "94", "Pattani");
            Add(Country.TH, "82", "Phangnga");
            Add(Country.TH, "93", "Phatthalung");
            Add(Country.TH, "S", "Phatthaya");
            Add(Country.TH, "56", "Phayao");
            Add(Country.TH, "67", "Phetchabun");
            Add(Country.TH, "76", "Phetchaburi");
            Add(Country.TH, "66", "Phichit");
            Add(Country.TH, "65", "Phitsanulok");
            Add(Country.TH, "14", "Phra Nakhon Si Ayutthaya");
            Add(Country.TH, "54", "Phrae");
            Add(Country.TH, "83", "Phuket");
            Add(Country.TH, "25", "Prachin Buri");
            Add(Country.TH, "77", "Prachuap Khiri Khan");
            Add(Country.TH, "85", "Ranong");
            Add(Country.TH, "70", "Ratchaburi");
            Add(Country.TH, "21", "Rayong");
            Add(Country.TH, "45", "Roi Et");
            Add(Country.TH, "27", "Sa Kaeo");
            Add(Country.TH, "47", "Sakon Nakhon");
            Add(Country.TH, "11", "Samut Prakan");
            Add(Country.TH, "74", "Samut Sakhon");
            Add(Country.TH, "75", "Samut Songkhram");
            Add(Country.TH, "19", "Saraburi");
            Add(Country.TH, "91", "Satun");
            Add(Country.TH, "33", "Si Sa Ket");
            Add(Country.TH, "17", "Sing Buri");
            Add(Country.TH, "90", "Songkhla");
            Add(Country.TH, "64", "Sukhothai");
            Add(Country.TH, "72", "Suphan Buri");
            Add(Country.TH, "84", "Surat Thani");
            Add(Country.TH, "32", "Surin");
            Add(Country.TH, "63", "Tak");
            Add(Country.TH, "92", "Trang");
            Add(Country.TH, "23", "Trat");
            Add(Country.TH, "34", "Ubon Ratchathani");
            Add(Country.TH, "41", "Udon Thani");
            Add(Country.TH, "61", "Uthai Thani");
            Add(Country.TH, "53", "Uttaradit");
            Add(Country.TH, "95", "Yala");
            Add(Country.TH, "35", "Yasothon");

            Debug.Assert(_subdivisionsPerCountry[Country.TH].Count == 78, $"{Country.TH} Number of subdivisions is wrong.");
        }
    }
}
