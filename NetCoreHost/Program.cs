using System;
using BenchmarkDotNet.Running;
using IdentityServerBenchmarks;

namespace NetCoreHost
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SerializerTests>();
        }
    }
}
