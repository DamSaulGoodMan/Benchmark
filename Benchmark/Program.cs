using System;
using Exportateur;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class pour récupérer (grâce à une Factory) et créer des types d'exportations
            var exportRetriever = new ExportRetrieve();
            exportRetriever.AddExport("JSON", new JSONTypeExport());
            
            // Builder pour créer un benchmark
            var benchmarkJSon = new CreateBenchmark()
                .Name("JsonBench")
                .AddTimer("WholeProgramTimer")
                .AddTimer("LoopTimer")
                .TypeOfExport(exportRetriever.GetExportClass("XML"))
                .Create();
            
            // Le Benchmark s'utilise en appellant la méthode StartRecord avec le nom d'un timer et StopRecord sur le même nom
            // pour calculer un temps de calcul entre ces deux appeles. 
            
            benchmarkJSon.StartRecord("WholeProgramTimer");
            for (var cnt = 0; cnt < 100;)
            {
                benchmarkJSon.StartRecord("LoopTimer");
                cnt++;
                benchmarkJSon.EndRecord("LoopTimer");
            }
            benchmarkJSon.EndRecord("WholeProgramTimer");
            
            
            // Exportation des données sur tout les types ajouter grâce à la commande
            benchmarkJSon.Export("/home/damsaulgoodman/");
        }
    }
}
