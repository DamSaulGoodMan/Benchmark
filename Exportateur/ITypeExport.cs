using System;
namespace Exportateur
{
    public interface ITypeExport
    {
        string name { get; set; }
        void Export();
    }
}
