using System.Collections.Generic;
using Exportateur;
using Util;

namespace Benchmark
{
    public interface IBenchmarkField
    {
        BenchmarkData Data { get; set; }

        ExportPool Exporter { get; set; }
    }
}