namespace Elders.Iso3166
{
    public partial struct EconomicZone
    {
        /// <summary>
        /// The Gulf Cooperation Council is a regional union of six Arab states of the Persian Gulf, with a customs union in place since 2003.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/Gulf_Cooperation_Council
        /// LastUpdated: 2026-08-15
        /// </remarks>
        internal static void GulfCooperationCouncil()
        {
            Add("GCC", "Gulf Cooperation Council", EconomicZoneType.CustomsUnion,
                Country.BH, Country.KW, Country.OM, Country.QA, Country.SA, Country.AE);
        }
    }
}
