using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using SystemMonitorWebService.VisitorPattern;

namespace SystemMonitorWebService.Models
{
    [DataContract]
    public class Performance
    {

        [DataMember]
        public DateTime Time { get; set; }

        [DataMember]
        public float Value { get; set; }
    }
}
