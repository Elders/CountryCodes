using BenchmarkDotNet.Attributes;
using Elders.Iso3166;

namespace Iso3166.Benchmarks
{
    [MemoryDiagnoser]
    public class Benchmarks
    {
        [Params(1000, 10_000, 100_000, 1_000_000)]
        public int N;

        private Country[] countries;

        [GlobalSetup]
        public void Setup()
        {
            countries = new Country[N];
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
    }
}
