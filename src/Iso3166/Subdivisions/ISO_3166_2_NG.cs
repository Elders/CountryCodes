using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:NG is the entry for Nigeria in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Nigeria, ISO 3166-2 codes are defined for 1 capital territory and 36 states.
        /// The Federal Capital Territory contains the capital of the country Abuja and has special status equal to the states.
        /// Each code consists of two parts, separated by a hyphen.The first part is NG, the ISO 3166-1 alpha-2 code of Nigeria.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:NG
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_NG()
        {
            Add(Country.NG, "FC", "Abuja Federal Capital Territory");
            Add(Country.NG, "AB", "Abia");
            Add(Country.NG, "AD", "Adamawa");
            Add(Country.NG, "AK", "Akwa Ibom");
            Add(Country.NG, "AN", "Anambra");
            Add(Country.NG, "BA", "Bauchi");
            Add(Country.NG, "BY", "Bayelsa");
            Add(Country.NG, "BE", "Benue");
            Add(Country.NG, "BO", "Borno");
            Add(Country.NG, "CR", "Cross River");
            Add(Country.NG, "DE", "Delta");
            Add(Country.NG, "EB", "Ebonyi");
            Add(Country.NG, "ED", "Edo");
            Add(Country.NG, "EK", "Ekiti");
            Add(Country.NG, "EN", "Enugu");
            Add(Country.NG, "GO", "Gombe");
            Add(Country.NG, "IM", "Imo");
            Add(Country.NG, "JI", "Jigawa");
            Add(Country.NG, "KD", "Kaduna");
            Add(Country.NG, "KN", "Kano");
            Add(Country.NG, "KT", "Katsina");
            Add(Country.NG, "KE", "Kebbi");
            Add(Country.NG, "KO", "Kogi");
            Add(Country.NG, "KW", "Kwara");
            Add(Country.NG, "LA", "Lagos");
            Add(Country.NG, "NA", "Nasarawa");
            Add(Country.NG, "NI", "Niger");
            Add(Country.NG, "OG", "Ogun");
            Add(Country.NG, "ON", "Ondo");
            Add(Country.NG, "OS", "Osun");
            Add(Country.NG, "OY", "Oyo");
            Add(Country.NG, "PL", "Plateau");
            Add(Country.NG, "RI", "Rivers");
            Add(Country.NG, "SO", "Sokoto");
            Add(Country.NG, "TA", "Taraba");
            Add(Country.NG, "YO", "Yobe");
            Add(Country.NG, "ZA", "Zamfar");

            Debug.Assert(_subdivisionsPerCountry[Country.NG].Count == 37, "Number of subdivisions is wrong.");
        }
    }
}
