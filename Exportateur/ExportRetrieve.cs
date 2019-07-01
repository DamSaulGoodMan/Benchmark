using System;
using System.Collections.Generic;

namespace Exportateur
{
    public class ExportRetrieve : IExportMaker
    {
        private readonly Dictionary<string, ITypeExport> _dicoExportType = new Dictionary<string, ITypeExport>()
        {
            {"XML", new XMLTypeExport()}
        };
        
        public ITypeExport GetExportClass(string exportTypesNames)
        {
            
            _dicoExportType.TryGetValue(exportTypesNames, out var typeExport);
            
            if(typeExport == null) throw new KeyNotFoundException("Export with name \"" +
                                                                  exportTypesNames + "\" not found");

            return typeExport;
        }

        public void AddExport(string nameExport, ITypeExport export)
        {
            _dicoExportType.Add(nameExport, export);
        }
    }
}