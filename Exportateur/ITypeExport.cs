using System;
using Util;

namespace Exportateur
{
    public interface ITypeExport
    {
        string name { get; set; }
        void Export(BenchmarkRecap recap, string path);
    }
}
