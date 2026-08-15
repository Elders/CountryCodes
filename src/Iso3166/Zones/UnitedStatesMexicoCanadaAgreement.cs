namespace Elders.Iso3166
{
    public partial struct EconomicZone
    {
        /// <summary>
        /// The United States-Mexico-Canada Agreement replaced NAFTA in 2020.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/United_States-Mexico-Canada_Agreement
        /// LastUpdated: 2026-08-15
        /// </remarks>
        internal static void UnitedStatesMexicoCanadaAgreement()
        {
            Add("USMCA", "United States-Mexico-Canada Agreement", EconomicZoneType.FreeTradeArea,
                Country.US, Country.CA, Country.MX);
        }
    }
}
