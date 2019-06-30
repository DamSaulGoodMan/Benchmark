using System.Collections.Generic;
using Exportateur;

namespace Benchmark
{
    public class CreateBenchmark
    {
        private class PrivateBenchmark: Benchmark { }
        private readonly Benchmark _benchmark;
        

        public CreateBenchmark()
        {
            _benchmark = new PrivateBenchmark();
        }
        
        public CreateBenchmark Name(string benchmarkName)
        {
            _benchmark.Name = benchmarkName;
            return this;
        }

        public CreateBenchmark Timers(string[] timersNames)
        {
            foreach (var name in timersNames)
            {
                _benchmark.DataTimers.Add(name, new List<double>());
            }

            return this;
        }

        public CreateBenchmark TypeOfExport(ITypeExport typeExport)
        {
            _benchmark.Exporter = typeExport;
            return this;
        }

        public Benchmark Create()
        {
            return _benchmark;
        }
    }
}