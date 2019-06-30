using System;
namespace Exportateur
{
    public class JSONTypeExport : ITypeExport
    {
        private string _name = "json";
        public string name
        {
            get => _name;
            set => _name = name;
        }

        public JSONTypeExport()
        {
        }

        public void Export() 
        {
        }
    }
}
