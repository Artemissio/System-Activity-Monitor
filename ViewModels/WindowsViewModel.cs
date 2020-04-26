using System.Collections.Generic;
using System.Linq;
using SystemActivityMonitor.SystemMonitorWebService;

namespace SystemActivityMonitor.ViewModels
{
    public class WindowsViewModel : IViewModel
    {
        public List<WindowInfo> Windows { get; set; } = new List<WindowInfo>();

        public WindowsViewModel()
        {
            Windows = new SystemMonitorService().GetOpenWindows().ToList();
        }
    }
}
