using System.Diagnostics;

namespace Elders.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:OM is the entry for Oman in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization(ISO),
        /// which defines codes for the names of the principal subdivisions(e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently for Oman, ISO 3166-2 codes are defined for 11 governorates.In 2011, the following subdivision changes took place:
        ///     Al Batinah Region(Al Bāţinah) split into Al Batinah North Governorate and Al Batinah South Governorate.
        ///     Ash Sharqiyah Region(Ash Sharqīyah) split into Ash Sharqiyah North Governorate and Ash Sharqiyah South Governorate.
        ///     Ad Dakhiliyah Region(Ad Dākhilīyah), Ad Dhahirah North Region(Az̧ Z̧āhirah), and Al Wusta Region(Al Wusţá) all became governorates.
        /// Each code consists of two parts, separated by a hyphen.The first part is OM, the ISO 3166-1 alpha-2 code of Oman.The second part is two letters.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:OM
        /// LastUpdated: 2023-03-22
        /// </remarks>
        internal static void ISO_3166_2_OM()
        {
            Add(Country.OM, "DA", "Ad Dākhilīyah");
            Add(Country.OM, "BU", "Al Buraymī");
            Add(Country.OM, "WU", "Al Wusţá");
            Add(Country.OM, "ZA", "Az̧ Z̧āhirah");
            Add(Country.OM, "BJ", "Janūb al Bāţinah");
            Add(Country.OM, "SJ", "Janūb ash Sharqīyah");
            Add(Country.OM, "MA", "Masqaţ");
            Add(Country.OM, "MU", "Musandam");
            Add(Country.OM, "BS", "Shamāl al Bāţinah");
            Add(Country.OM, "SS", "Shamāl ash Sharqīyah");
            Add(Country.OM, "ZU", "Z̧ufār");

            Debug.Assert(_subdivisionsPerCountry[Country.OM].Count == 11, $"{Country.OM} Number of subdivisions is wrong.");
        }
    }
}
