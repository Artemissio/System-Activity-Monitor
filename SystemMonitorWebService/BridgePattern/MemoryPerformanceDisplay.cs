using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitorWebService.BridgePattern
{
    public class MemoryPerformanceDisplay : AbstractPerformanceDisplay
    {
        public MemoryPerformanceDisplay(IPerformanceSingleton performanceSingleton) : base(performanceSingleton)
        {
        }
    }
}
