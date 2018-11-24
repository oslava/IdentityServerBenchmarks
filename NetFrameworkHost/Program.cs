using BenchmarkDotNet.Running;
using IdentityServerBenchmarks;

namespace NetFrameworkHost
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SerializerTests>();
        }
    }
}
