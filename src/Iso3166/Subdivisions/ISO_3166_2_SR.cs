using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SR is the entry for Suriname in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Suriname, ISO 3166-2 codes are defined for 10 districts.
        /// Each code consists of two parts, separated by a hyphen.The first part is SR, the ISO 3166-1 alpha-2 code of Suriname.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SR
        /// LastUpdated: 2023-03-20
        /// </remarks>
        internal static void ISO_3166_2_SR()
        {
            Add(Country.SR, "BR", "Brokopondo");
            Add(Country.SR, "CM", "Commewijne");
            Add(Country.SR, "CR", "Coronie");
            Add(Country.SR, "MA", "Marowijne");
            Add(Country.SR, "NI", "Nickerie");
            Add(Country.SR, "PR", "Para");
            Add(Country.SR, "PM", "Paramaribo");
            Add(Country.SR, "SA", "Saramacca");
            Add(Country.SR, "SI", "Sipaliwini");
            Add(Country.SR, "WA", "Wanica");

            Debug.Assert(_subdivisionsPerCountry[Country.SR].Count == 10, $"{Country.SR} Number of subdivisions is wrong.");
        }
    }
}
