using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Models;

namespace SystemActivityMonitor.BridgePattern
{
    public interface IPerformanceSingleton
    {
        List<Performance> GetPerformance();
    }
}
