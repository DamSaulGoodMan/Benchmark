using System;
using Exportateur;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var exportRetriever = new ExportRetrieve();
            var benchmarkJSon = new CreateBenchmark()
                .Name("JsonBench")
                .AddTimer("WholeProgramTimer")
                .AddTimer("LoopTimer")
                .TypeOfExport(exportRetriever.GetExportClass("XML"))
                .Create();
            
            benchmarkJSon.StartRecord("WholeProgramTimer");
            for (var cnt = 0; cnt < 100;)
            {
                benchmarkJSon.StartRecord("LoopTimer");
                cnt++;
                benchmarkJSon.EndRecord("LoopTimer");
            }
            benchmarkJSon.EndRecord("WholeProgramTimer");
            
            benchmarkJSon.Export("/home/damsaulgoodman/");
        }
    }
}
