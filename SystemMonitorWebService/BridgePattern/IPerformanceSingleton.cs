using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemMonitorWebService.Models;

namespace SystemMonitorWebService.BridgePattern
{
    public interface IPerformanceSingleton
    {
        List<Performance> GetPerformance();
    }
}
