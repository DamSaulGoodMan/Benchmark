using System;
namespace Exportateur
{
    public class XMLTypeExport:ITypeExport
    {
        private string _name = "xml";
        public string name
        {
            get => _name;
            set => _name = name;
        }

        public XMLTypeExport()
        {
        }

        public void Export() { }
    }
}
