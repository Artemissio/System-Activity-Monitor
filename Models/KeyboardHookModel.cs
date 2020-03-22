using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemActivityMonitor.Models
{
    public class KeyboardHookModel
    {
        public string EventType { get; set; }
        public string Time { get; set; }
        //public string KeyCode { get; set; }
        public string KeyChar { get; set; }
        //public string Shift { get; set; }
        //public string Alt { get; set; }
        //public string Control { get; set; }
    }
}
