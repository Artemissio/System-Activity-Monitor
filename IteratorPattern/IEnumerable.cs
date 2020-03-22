using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemActivityMonitor.IteratorPattern
{
    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }
}
