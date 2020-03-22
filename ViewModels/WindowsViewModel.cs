using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Models;

namespace SystemActivityMonitor.ViewModels
{
    public class WindowsViewModel : IViewModel
    {
        public List<WindowInfo> Windows { get; set; } = new List<WindowInfo>();

        public WindowsViewModel()
        {
            GetOpenWindows();
        }

        public void GetOpenWindows()
        {
            List<WindowInfo> windows;

            WindowsStatistics.GetDesktopWindows(out windows);

            Windows = windows;
        }
    }
}
