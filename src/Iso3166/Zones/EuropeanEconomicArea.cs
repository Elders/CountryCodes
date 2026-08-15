namespace Elders.Iso3166
{
    public partial struct EconomicZone
    {
        /// <summary>
        /// The European Economic Area extends the single market to Iceland, Liechtenstein and Norway. Switzerland is a member of EFTA but declined to join the EEA and trades with the European Union through bilateral treaties instead.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/European_Economic_Area
        /// LastUpdated: 2026-08-15
        /// </remarks>
        internal static void EuropeanEconomicArea()
        {
            Add("EEA", "European Economic Area", EconomicZoneType.SingleMarket,
                Country.AT, Country.BE, Country.BG, Country.HR, Country.CY, Country.CZ, Country.DK, Country.EE,
                Country.FI, Country.FR, Country.DE, Country.GR, Country.HU, Country.IE, Country.IT, Country.LV,
                Country.LT, Country.LU, Country.MT, Country.NL, Country.PL, Country.PT, Country.RO, Country.SK,
                Country.SI, Country.ES, Country.SE, Country.IS, Country.LI, Country.NO);
        }
    }
}
