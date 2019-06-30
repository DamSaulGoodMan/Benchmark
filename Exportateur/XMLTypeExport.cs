using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using Util;

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

        public void Export(BenchmarkRecap recap,string path)
        {
            MemoryStream ms = new MemoryStream();
            DataContractSerializer dcs = new DataContractSerializer(typeof(BenchmarkRecap));
            XmlDictionaryWriter xdw = XmlDictionaryWriter.CreateTextWriter(ms, Encoding.UTF8);
            dcs.WriteObject(xdw, recap);
            byte[] xml = ms.ToArray();
            ms.Close();
            Writer.Instance.Write(path, Encoding.UTF8.GetString(xml, 0, xml.Length));
        }
    }
}
