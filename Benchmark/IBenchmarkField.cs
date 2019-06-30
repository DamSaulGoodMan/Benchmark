using System.Collections.Generic;
using Exportateur;

namespace Benchmark
{
    public interface IBenchmarkField
    {
        string Name { get; set; }
        Dictionary<string, List<double>> DataTimers { get; set; }

        ITypeExport Exporter { get; set; }
    }
}