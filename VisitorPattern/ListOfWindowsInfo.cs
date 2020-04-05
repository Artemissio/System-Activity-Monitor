using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Models;

namespace SystemActivityMonitor.VisitorPattern
{
    public class ListOfWindowsInfo : IElement
    {
        List<WindowInfo> _windows = new List<WindowInfo>();

        public void Accept(IVisitor visitor)
        {
            WindowsStatistics.GetDesktopWindows(out List<WindowInfo> windows);

            _windows = windows;

            visitor.VisitWindowsList(this);
        }

        public List<WindowInfo> GetWindows()
        {
            return _windows;
        }
    }
}
