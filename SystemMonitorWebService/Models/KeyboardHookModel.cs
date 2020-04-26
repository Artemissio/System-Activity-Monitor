using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitorWebService.Models
{
    [DataContract]
    public class KeyboardHookModel
    {
        [DataMember]
        public string EventType { get; set; }

        [DataMember]
        public string Time { get; set; }

        [DataMember]
        public string KeyChar { get; set; }
    }
}
