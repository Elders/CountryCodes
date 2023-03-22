using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166 - 2:BD is the entry for Bangladesh in ISO 3166 - 2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166 - 1.
        /// Currently for Bangladesh, ISO 3166 - 2 codes are defined for two levels of subdivisions:
        ///     8 divisions
        ///     64 districts
        /// Each code consists of two parts, separated by a hyphen.The first part is BD, the ISO 3166 - 1 alpha - 2 code of Bangladesh.The second part is either of the following:
        ///     one letter(A–H): divisions
        ///     two digits(01–64) : districts
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:BD
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_BD()
        {
            Add(Country.BD, "A", "Barishal");
            Add(Country.BD, "B", "Chattogram");
            Add(Country.BD, "C", "Dhaka");
            Add(Country.BD, "D", "Khulna");
            Add(Country.BD, "H", "Mymensingh");
            Add(Country.BD, "E", "Rajshahi");
            Add(Country.BD, "F", "Rangpur");
            Add(Country.BD, "G", "Sylhet");
            Add(Country.BD, "05", "Bagerhat");
            Add(Country.BD, "01", "Bandarban");
            Add(Country.BD, "02", "Barguna");
            Add(Country.BD, "06", "Barishal");
            Add(Country.BD, "07", "Bhola");
            Add(Country.BD, "03", "Bogura");
            Add(Country.BD, "04", "Brahmanbaria");
            Add(Country.BD, "09", "Chandpur");
            Add(Country.BD, "45", "Chapai Nawabganj");
            Add(Country.BD, "10", "Chattogram");
            Add(Country.BD, "12", "Chuadanga");
            Add(Country.BD, "11", "Cos Bazar");
            Add(Country.BD, "08", "Cumilla");
            Add(Country.BD, "13", "Dhaka");
            Add(Country.BD, "14", "Dinajpur");
            Add(Country.BD, "15", "Faridpur");
            Add(Country.BD, "16", "Feni");
            Add(Country.BD, "19", "Gaibandha");
            Add(Country.BD, "18", "Gazipur");
            Add(Country.BD, "17", "Gopalganj");
            Add(Country.BD, "20", "Habiganj");
            Add(Country.BD, "21", "Jamalpur");
            Add(Country.BD, "22", "Jashore");
            Add(Country.BD, "25", "Jhalakathi");
            Add(Country.BD, "23", "Jhenaidah");
            Add(Country.BD, "24", "Joypurhat");
            Add(Country.BD, "29", "Khagrachhari");
            Add(Country.BD, "27", "Khulna");
            Add(Country.BD, "26", "Kishoreganj");
            Add(Country.BD, "28", "Kurigram");
            Add(Country.BD, "30", "Kushtia");
            Add(Country.BD, "31", "Lakshmipur");
            Add(Country.BD, "32", "Lalmonirhat");
            Add(Country.BD, "36", "Madaripur");
            Add(Country.BD, "37", "Magura");
            Add(Country.BD, "33", "Manikganj");
            Add(Country.BD, "39", "Meherpur");
            Add(Country.BD, "38", "Moulvibazar");
            Add(Country.BD, "35", "Munshiganj");
            Add(Country.BD, "34", "Mymensingh");
            Add(Country.BD, "48", "Naogaon");
            Add(Country.BD, "43", "Narail");
            Add(Country.BD, "40", "Narayanganj");
            Add(Country.BD, "42", "Narsingdi");
            Add(Country.BD, "44", "Natore");
            Add(Country.BD, "41", "Netrakona");
            Add(Country.BD, "46", "Nilphamari");
            Add(Country.BD, "47", "Noakhali");
            Add(Country.BD, "49", "Pabna");
            Add(Country.BD, "52", "Panchagarh");
            Add(Country.BD, "51", "Patuakhali");
            Add(Country.BD, "50", "Pirojpur");
            Add(Country.BD, "53", "Rajbari");
            Add(Country.BD, "54", "Rajshahi");
            Add(Country.BD, "56", "Rangamati");
            Add(Country.BD, "55", "Rangpur");
            Add(Country.BD, "58", "Satkhira");
            Add(Country.BD, "62", "Shariatpur");
            Add(Country.BD, "57", "Sherpur");
            Add(Country.BD, "59", "Sirajganj");
            Add(Country.BD, "61", "Sunamganj");
            Add(Country.BD, "60", "Sylhet");
            Add(Country.BD, "63", "Tangail");
            Add(Country.BD, "64", "Thakurgaon");

            Debug.Assert(_subdivisionsPerCountry[Country.BD].Count == 72, "Number of subdivisions is wrong.");
        }
    }
}
