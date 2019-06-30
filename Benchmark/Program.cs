using System;
using Exportateur;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var benchmarkJSon = new CreateBenchmark()
                .Name("JsonBench")
                .Timers(new string[] {"MainTimer", "EndTimer"})
                .TypeOfExport(new JSONTypeExport())
                .Create();
        }

        public void Start() 
        {
        
        }

        public void Stop()
        {
        
        }

        public void Interrupt() 
        {
        
        }
    }
}
