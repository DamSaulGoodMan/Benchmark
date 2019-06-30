using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Util;

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

        public void Export(BenchmarkData data, string path) 
        {
            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(BenchmarkData));
            ser.WriteObject(ms, data);
            byte[] json = ms.ToArray();
            ms.Close();
            Writer.Instance.Write(path + "/" + data._name + ".json",
                Encoding.UTF8.GetString(json, 0, json.Length));
        }
    }
}
