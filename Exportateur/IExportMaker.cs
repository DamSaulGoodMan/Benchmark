using System.Collections.Generic;

namespace Exportateur
{
    public interface IExportMaker
    {
        ITypeExport GetExportClass(string exportTypesNames);
    }
}