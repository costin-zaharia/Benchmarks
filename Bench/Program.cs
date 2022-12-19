using Bench.CollectionsBenchmark;
using BenchmarkDotNet.Running;

namespace Bench
{
    public class Program
    {
        public static void Main() => BenchmarkRunner.Run(typeof(Lookup));
    }
}
