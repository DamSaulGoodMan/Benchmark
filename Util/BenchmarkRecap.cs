using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Util
{
    [DataContract]
    public class BenchmarkRecap
    {

        public BenchmarkRecap(string name, List<TestZone> testZones)
        {
            this.name = name;
            this.testZones = testZones;
        }

        private string name;
        [DataMember]
        public string _name { get => name; set => this.name = _name; }

        private List<TestZone> testZones;
        [DataMember]
        public List<TestZone> _testZones { get => testZones; set => this.testZones = _testZones; }

    }
}
