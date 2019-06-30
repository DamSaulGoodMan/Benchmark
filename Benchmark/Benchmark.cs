using System.Collections.Generic;
using Exportateur;

namespace Benchmark
{
    public class Benchmark : IBenchmarkField
    {
        private protected Benchmark() {}
        
        public string Name { get; set; }
        public Dictionary<string, List<double>> DataTimers { get; set; }
        public ITypeExport Exporter { get; set; }
    }
}