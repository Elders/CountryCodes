using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:UA is the entry for Ukraine in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Ukraine, ISO 3166-2 codes are defined for 24 regions, 1 republic, and 2 cities, including codes for the Autonomous Republic of Crimea and Sevastopol
        /// which continue to be internationally recognized as part of Ukraine though have been de facto administered by the Russian Federation since 2014.
        /// The two cities have special status equal to the regions.
        /// Each code consists of two parts, separated by a hyphen. The first part is UA, the ISO 3166-1 alpha-2 code of Ukraine.
        /// The second part is two digits, which is taken from the local standard KOATUU (Ukrainian: КОАТУУ), with the following exceptions:
        ///     Chernivtsi Oblast uses 77 (its KOATUU code is 73)
        ///     Luhansk Oblast uses 09 (its KOATUU code is 44)
        ///     The Autonomous Republic of Crimea uses 43 (its KOATUU code is 01)
        ///     The city Kyiv uses 30 (its KOATUU code is 80)
        ///     The city Sevastopol uses 40 (its KOATUU code is 85)
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:UA
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_UA()
        {
            Add(Country.UA, "71", "Cherkaska oblast");
            Add(Country.UA, "74", "Chernihivska oblast");
            Add(Country.UA, "77", "Chernivetska oblast");
            Add(Country.UA, "12", "Dnipropetrovska oblast");
            Add(Country.UA, "14", "Donetska oblast");
            Add(Country.UA, "26", "Ivano-Frankivska oblast");
            Add(Country.UA, "63", "Kharkivska oblast");
            Add(Country.UA, "65", "Khersonska oblast");
            Add(Country.UA, "68", "Khmelnytska oblast");
            Add(Country.UA, "35", "Kirovohradska oblast");
            Add(Country.UA, "32", "Kyivska oblast");
            Add(Country.UA, "09", "Luhanska oblast");
            Add(Country.UA, "46", "Lvivska oblast");
            Add(Country.UA, "48", "Mykolaivska oblast");
            Add(Country.UA, "51", "Odeska oblast");
            Add(Country.UA, "53", "Poltavska oblast");
            Add(Country.UA, "56", "Rivnenska oblast");
            Add(Country.UA, "59", "Sumska oblast");
            Add(Country.UA, "61", "Ternopilska oblast");
            Add(Country.UA, "05", "Vinnytska oblast");
            Add(Country.UA, "07", "Volynska oblast");
            Add(Country.UA, "21", "Zakarpatska oblast");
            Add(Country.UA, "23", "Zaporizka oblast");
            Add(Country.UA, "18", "Zhytomyrska oblast");
            Add(Country.UA, "43", "Avtonomna Respublika Krym");
            Add(Country.UA, "30", "Kyiv");
            Add(Country.UA, "40", "Sevastopol");

            Debug.Assert(_subdivisionsPerCountry[Country.UA].Count == 27, $"{Country.UA} Number of subdivisions is wrong.");
        }
    }
}
