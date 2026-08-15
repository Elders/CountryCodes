namespace Elders.Iso3166
{
    public partial struct EconomicZone
    {
        /// <summary>
        /// The euro area is made up of the European Union member states that have adopted the euro. Bulgaria adopted it on 2026-01-01, bringing the total to 21. Czechia, Denmark, Hungary, Poland, Romania and Sweden keep their own currencies.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/Eurozone
        /// LastUpdated: 2026-08-15
        /// </remarks>
        internal static void EuroArea()
        {
            Add("EA", "Euro area", EconomicZoneType.MonetaryUnion,
                Country.AT, Country.BE, Country.BG, Country.HR, Country.CY, Country.EE, Country.FI, Country.FR,
                Country.DE, Country.GR, Country.IE, Country.IT, Country.LV, Country.LT, Country.LU, Country.MT,
                Country.NL, Country.PT, Country.SK, Country.SI, Country.ES);
        }
    }
}
