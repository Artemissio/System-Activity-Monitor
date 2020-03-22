using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemActivityMonitor.Models
{
    public class MouseHookModel
    {
        public string EventType { get; set; }
        public string Button { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
    }
}
