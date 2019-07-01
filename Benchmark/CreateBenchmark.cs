using System.Collections.Generic;
using Exportateur;
using Util;

namespace Benchmark
{
    public class CreateBenchmark
    {
        private class PrivateBenchmark: Benchmark { }
        private readonly Benchmark _benchmark;
        

        public CreateBenchmark()
        {
            _benchmark = new PrivateBenchmark();
            _benchmark.Exporter = new ExportPool(new List<ITypeExport>());
        }
        
        public CreateBenchmark Name(string benchmarkName)
        {
            _benchmark.Data = new BenchmarkData(benchmarkName,new Dictionary<string, TestZone>());
            return this;
        }

        public CreateBenchmark AddTimer(string timerName)
        {
            _benchmark.Data._testZones.Add(timerName, new TestZone(timerName, new Stack<long>()));
            
            return this;
        }

        public CreateBenchmark TypeOfExport(ITypeExport typeExport)
        {
            _benchmark.Exporter.AddExport(typeExport);
            return this;
        }

        public Benchmark Create()
        {
            return _benchmark;
        }
    }
}