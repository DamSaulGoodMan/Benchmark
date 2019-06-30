using System;
using System.Runtime.Serialization;

namespace Util
{
    [DataContract]
    public class TestZone
    {
        public TestZone(string name,int indice)
        {
            this.name = name;
            this.indice = indice;
        }

        private string name;
        [DataMember]
        public string _name { get => name; set => this.name = _name; }

        private int indice;
        [DataMember]
        public int _indice { get => indice; set => this.indice = _indice; }

    }
}
