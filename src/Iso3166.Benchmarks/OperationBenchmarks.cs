using BenchmarkDotNet.Attributes;
using Elders.Iso3166;

namespace Iso3166.Benchmarks
{
    /// <summary>
    /// Single operations on an already-resolved country or zone. These carry no N parameter because their cost
    /// does not depend on how many times a caller repeats them.
    /// </summary>
    [MemoryDiagnoser]
    public class OperationBenchmarks
    {
        [Benchmark]
        public bool CountryEqualsTrue()
        {
            return Country.BG == Country.BG;
        }

        [Benchmark]
        public bool CountryEqualsTrueNew()
        {
            return new Country("BG") == new Country("BG");
        }

        [Benchmark]
        public bool CountryEqualsFalse()
        {
            return Country.BG == Country.US;
        }

        [Benchmark]
        public bool CountryEqualsFalseNew()
        {
            return new Country("BG") == new Country("US");
        }

        [Benchmark]
        public bool ZoneEqualsTrue()
        {
            return EconomicZone.EU == EconomicZone.EU;
        }

        [Benchmark]
        public bool ZoneEqualsTrueNew()
        {
            return new EconomicZone("EU") == new EconomicZone("EU");
        }

        [Benchmark]
        public bool ZoneEqualsFalse()
        {
            return EconomicZone.EU == EconomicZone.EFTA;
        }

        [Benchmark]
        public bool ZoneEqualsFalseNew()
        {
            return new EconomicZone("EU") == new EconomicZone("EFTA");
        }

        [Benchmark]
        public bool ZoneContainsTrue()
        {
            return EconomicZone.EU.Contains(Country.BG);
        }

        [Benchmark]
        public bool ZoneContainsFalse()
        {
            return EconomicZone.EU.Contains(Country.US);
        }

        [Benchmark]
        public bool CountryIsIn()
        {
            return Country.BG.IsIn(EconomicZone.EU);
        }

        [Benchmark]
        public string ZoneName()
        {
            return EconomicZone.EU.Name;
        }

        [Benchmark]
        public int CountryZones()
        {
            int count = 0;
            foreach (var zone in Country.BG.Zones)
            {
                count++;
            }

            return count;
        }
    }
}
