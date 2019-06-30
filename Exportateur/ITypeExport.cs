using System;
using Util;

namespace Exportateur
{
    public interface ITypeExport
    {
        string name { get; set; }
        void Export(BenchmarkData data, string path);
    }
}
