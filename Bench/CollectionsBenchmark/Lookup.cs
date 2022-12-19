using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Bench.CollectionsBenchmark
{
    [SimpleJob(RuntimeMoniker.Net462)]
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70, baseline: true)]
    public class Lookup
    {
        private int[] array;
        private ImmutableArray<int> immutableArray;
        private List<int> list;
        private ImmutableList<int> immutableList;
        private HashSet<int> hashSet;
        private ImmutableHashSet<int> immutableHashSet;
        private Dictionary<int, int> dictionary;
        private ImmutableDictionary<int, int> immutableDictionary;

        [Params(1_000)]
        public int Count;

        [GlobalSetup]
        public void Setup()
        {
            array = Enumerable.Range(0, Count).ToArray();
            immutableArray = array.ToImmutableArray();

            list = array.ToList();
            immutableList = array.ToImmutableList();

            hashSet = array.ToHashSet();
            immutableHashSet = array.ToImmutableHashSet();

            dictionary = array.ToDictionary(i => i);
            immutableDictionary = array.ToImmutableDictionary(i => i);
        }

        [Benchmark]
        public void ArrayLookup()
        {
            for (var i = 0; i < array.Length; i++)
            {
                array.Contains(i);
            }
        }

        [Benchmark]
        public void ImmutableArrayLookup()
        {
            for (var i = 0; i < immutableArray.Length; i++)
            {
                immutableArray.Contains(i);
            }
        }

        [Benchmark]
        public void ListLookup()
        {
            for (var i = 0; i < list.Count; i++)
            {
                list.Contains(i);
            }
        }

        [Benchmark]
        public void ImmutableListLookup()
        {
            for (var i = 0; i < immutableList.Count; i++)
            {
                immutableList.Contains(i);
            }
        }

        [Benchmark]
        public void HashSetLookup()
        {
            for (var i = 0; i < hashSet.Count; i++)
            {
                hashSet.Contains(i);
            }
        }

        [Benchmark]
        public void ImmutableHashSetLookup()
        {
            for (var i = 0; i < immutableHashSet.Count; i++)
            {
                immutableHashSet.Contains(i);
            }
        }

        [Benchmark]
        public void DictionaryLookup()
        {
            for (var i = 0; i < dictionary.Keys.Count; i++)
            {
                dictionary.ContainsKey(i);
            }
        }

        [Benchmark]
        public void ImmutableDictionaryLookup()
        {
            for (var i = 0; i < immutableDictionary.Count; i++)
            {
                immutableDictionary.ContainsKey(i);
            }
        }
    }
}
