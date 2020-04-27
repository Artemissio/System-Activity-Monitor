using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitorWebService.Models
{
    [DataContract]
    public class WindowInfo
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Date { get; set; }
    }
}
