using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Util
{
    [DataContract]
    public class TestZone
    {
        public TestZone(string name, Stack<long> executionTimeList)
        {
            this.name = name;
            this.executionTimeList = executionTimeList;
        }

        private string name;
        [DataMember]
        public string _name { get => name; set => this.name = _name; }

        private Stack<long> executionTimeList;
        [DataMember]
        public Stack<long> _executionTimeList { get => executionTimeList; 
            set => this.executionTimeList = _executionTimeList; }

    }
}
