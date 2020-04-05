using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Models;

namespace SystemActivityMonitor.VisitorPattern
{
    class WindowComparer : IComparer<WindowInfo>
    {
        public int Compare(WindowInfo x, WindowInfo y)
        {
            if (x.ID > y.ID)
            {
                return 1;
            }
            else if (x.ID < y.ID)
            {
                return -1;
            }

            return 0;
        }
    }
}
