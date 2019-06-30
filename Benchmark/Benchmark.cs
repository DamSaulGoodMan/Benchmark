using System;
using System.Collections.Generic;
using Exportateur;
using Util;

namespace Benchmark
{
    public class Benchmark : IBenchmarkField, IBenchmarkExport
    {
        protected Benchmark() {}

        public BenchmarkData Data { get; set; }
        public ExportPool Exporter { get; set; }
        public void Export(string path)
        {
            Exporter.ExecuteExports(Data, path);
        }

        public void StartRecord(string testZoneName)
        {
            Data._testZones[testZoneName]._executionTimeList.Push(DateTime.Now.Ticks);
        }
        
        public void EndRecord(string testZoneName)
        {
            Data._testZones[testZoneName]._executionTimeList
                .Push(DateTime.Now.Ticks - Data._testZones[testZoneName]._executionTimeList.Pop());
        }
    }
}