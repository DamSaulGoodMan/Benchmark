using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Util
{
    [DataContract]
    public class BenchmarkData
    {

        public BenchmarkData(string name, Dictionary<string, TestZone> testZones)
        {
            this.name = name;
            this.testZones = testZones;
        }

        private string name;
        [DataMember]
        public string _name { get => name; set => this.name = _name; }

        private Dictionary<string, TestZone> testZones;
        [DataMember]
        public Dictionary<string, TestZone> _testZones { get => testZones; set => this.testZones = _testZones; }

    }
}
