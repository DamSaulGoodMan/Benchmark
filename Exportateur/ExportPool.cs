using System;
using System.Collections.Generic;
using Util;

namespace Exportateur
{
    public class ExportPool
    {
        private List<ITypeExport> _listExport;
        public ExportPool(List<ITypeExport> listExport)
        {
            _listExport = listExport;
        }

        public void AddExport(ITypeExport typeExport)
        {
            _listExport.Add(typeExport);
        }

        public void ExecuteExports(BenchmarkData benchmarkData, string path)
        {
            foreach (var export in _listExport)
            {
                Console.Out.WriteLine(export.name);
                export.Export(benchmarkData, path);
            }
        }
    }
}