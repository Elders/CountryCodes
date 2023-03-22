using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:TR is the entry for Turkey (spelled "Türkiye") in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Turkey, ISO 3166-2 codes are defined for 81 provinces.
        /// Each code consists of two parts, separated by a hyphen. The first part is TR, the ISO 3166-1 alpha-2 code of Turkey. The second part is two digits:
        ///     01–67: provinces as of mid 1980s
        ///     68–71: provinces created in 1989
        ///     72–73: provinces created in 1990
        ///     74: province created in 1991
        ///     75–76: provinces created in 1994
        ///     77–79: provinces created in 1995
        ///     80: province created in 1997
        ///     81: province created in 1999
        /// The digits are currently used in vehicle registration plates and postal codes. The codes 01–67 are assigned in Turkish alphabetical order, except Mersin, Kahramanmaraş and Şanlıurfa,
        /// whose codes are assigned based on their historic names, İçel, Maraş and Urfa respectively.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:TR
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_TR()
        {
            Add(Country.TR, "01", "Adana");
            Add(Country.TR, "02", "Adıyaman");
            Add(Country.TR, "03", "Afyonkarahisar");
            Add(Country.TR, "04", "Ağrı");
            Add(Country.TR, "68", "Aksaray");
            Add(Country.TR, "05", "Amasya");
            Add(Country.TR, "06", "Ankara");
            Add(Country.TR, "07", "Antalya");
            Add(Country.TR, "75", "Ardahan");
            Add(Country.TR, "08", "Artvin");
            Add(Country.TR, "09", "Aydın");
            Add(Country.TR, "10", "Balıkesir");
            Add(Country.TR, "74", "Bartın");
            Add(Country.TR, "72", "Batman");
            Add(Country.TR, "69", "Bayburt");
            Add(Country.TR, "11", "Bilecik");
            Add(Country.TR, "12", "Bingöl");
            Add(Country.TR, "13", "Bitlis");
            Add(Country.TR, "14", "Bolu");
            Add(Country.TR, "15", "Burdur");
            Add(Country.TR, "16", "Bursa");
            Add(Country.TR, "17", "Çanakkale");
            Add(Country.TR, "18", "Çankırı");
            Add(Country.TR, "19", "Çorum");
            Add(Country.TR, "20", "Denizli");
            Add(Country.TR, "21", "Diyarbakır");
            Add(Country.TR, "81", "Düzce");
            Add(Country.TR, "22", "Edirne");
            Add(Country.TR, "23", "Elazığ");
            Add(Country.TR, "24", "Erzincan");
            Add(Country.TR, "25", "Erzurum");
            Add(Country.TR, "26", "Eskişehir");
            Add(Country.TR, "27", "Gaziantep");
            Add(Country.TR, "28", "Giresun");
            Add(Country.TR, "29", "Gümüşhane");
            Add(Country.TR, "30", "Hakkâri");
            Add(Country.TR, "31", "Hatay");
            Add(Country.TR, "76", "Iğdır");
            Add(Country.TR, "32", "Isparta");
            Add(Country.TR, "34", "İstanbul");
            Add(Country.TR, "35", "İzmir");
            Add(Country.TR, "46", "Kahramanmaraş");
            Add(Country.TR, "78", "Karabük");
            Add(Country.TR, "70", "Karaman");
            Add(Country.TR, "36", "Kars");
            Add(Country.TR, "37", "Kastamonu");
            Add(Country.TR, "38", "Kayseri");
            Add(Country.TR, "71", "Kırıkkale");
            Add(Country.TR, "39", "Kırklareli");
            Add(Country.TR, "40", "Kırşehir");
            Add(Country.TR, "79", "Kilis");
            Add(Country.TR, "41", "Kocaeli");
            Add(Country.TR, "42", "Konya");
            Add(Country.TR, "43", "Kütahya");
            Add(Country.TR, "44", "Malatya");
            Add(Country.TR, "45", "Manisa");
            Add(Country.TR, "47", "Mardin");
            Add(Country.TR, "33", "Mersin");
            Add(Country.TR, "48", "Muğla");
            Add(Country.TR, "49", "Muş");
            Add(Country.TR, "50", "Nevşehir");
            Add(Country.TR, "51", "Niğde");
            Add(Country.TR, "52", "Ordu");
            Add(Country.TR, "80", "Osmaniye");
            Add(Country.TR, "53", "Rize");
            Add(Country.TR, "54", "Sakarya");
            Add(Country.TR, "55", "Samsun");
            Add(Country.TR, "56", "Siirt");
            Add(Country.TR, "57", "Sinop");
            Add(Country.TR, "58", "Sivas");
            Add(Country.TR, "63", "Şanlıurfa");
            Add(Country.TR, "73", "Şırnak");
            Add(Country.TR, "59", "Tekirdağ");
            Add(Country.TR, "60", "Tokat");
            Add(Country.TR, "61", "Trabzon");
            Add(Country.TR, "62", "Tunceli");
            Add(Country.TR, "64", "Uşak");
            Add(Country.TR, "65", "Van");
            Add(Country.TR, "77", "Yalova");
            Add(Country.TR, "66", "Yozgat");
            Add(Country.TR, "67", "Zonguldak");

            Debug.Assert(_subdivisionsPerCountry[Country.TR].Count == 81, "Number of subdivisions is wrong.");
        }
    }
}
