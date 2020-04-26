using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemMonitorWebService.Models;

namespace SystemMonitorWebService.BridgePattern
{
    public abstract class AbstractPerformanceDisplay
    {
        protected IPerformanceSingleton _performanceSingleton;

        public AbstractPerformanceDisplay(IPerformanceSingleton performanceSingleton)
        {
            _performanceSingleton = performanceSingleton;
        }

        public virtual List<Performance> GetPerformance()
        {
            return _performanceSingleton.GetPerformance();
        }
    }
}
