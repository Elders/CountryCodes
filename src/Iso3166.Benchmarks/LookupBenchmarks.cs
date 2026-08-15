using BenchmarkDotNet.Attributes;
using Elders.Iso3166;

namespace Iso3166.Benchmarks
{
    /// <summary>
    /// Resolving countries and zones in a loop, where the cost scales with the number of lookups.
    /// </summary>
    [MemoryDiagnoser]
    public class LookupBenchmarks
    {
        [Params(1000, 10_000, 100_000, 1_000_000)]
        public int N;

        private Country[] countries;
        private EconomicZone[] zones;

        [GlobalSetup]
        public void Setup()
        {
            countries = new Country[N];
            zones = new EconomicZone[N];
        }

        [Benchmark]
        public Country[] CountryById()
        {
            for (int i = 0; i < N; i++)
            {
                countries[i] = new Country(100);
            }

            return countries;
        }

        [Benchmark]
        public Country[] CountryByCode()
        {
            for (int i = 0; i < N; i++)
            {
                countries[i] = new Country("BG");
            }

            return countries;
        }

        [Benchmark]
        public Country[] CountryStaticFieldAccess()
        {
            for (int i = 0; i < N; i++)
            {
                countries[i] = Country.BG;
            }

            return countries;
        }

        [Benchmark]
        public EconomicZone[] ZoneByCode()
        {
            for (int i = 0; i < N; i++)
            {
                zones[i] = new EconomicZone("EU");
            }

            return zones;
        }

        [Benchmark]
        public EconomicZone[] ZoneStaticFieldAccess()
        {
            for (int i = 0; i < N; i++)
            {
                zones[i] = EconomicZone.EU;
            }

            return zones;
        }
    }
}
