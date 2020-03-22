using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemActivityMonitor.IteratorPattern
{
    public  class IdComparer : IComparer<Process>
    {
        public int Compare(Process x, Process y)
        {
            if (x.Id > y.Id)
            {
                return 1;
            }
            else if (x.Id < y.Id)
            {
                return -1;
            }

            return 0;
        }
    }
}
