using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace Vektorel.StringBenchmarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = DefaultConfig.Instance;
            
            var summary = BenchmarkRunner.Run<StringComparisons>(config, args);
            //var summary = BenchmarkRunner.Run<StringBuilderVSPlus>(config, args);
        }
    }
}
