using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RoomAutomationSystem
{
    [DataContract]
    public class Pressure
    {
        [DataMember]
        public decimal Frequency { get; set; }
        [DataMember]
        public DateTime Date { get; set; }

    }
}
