using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitorWebService.IteratorPattern
{
    public class ProcessesCollection : IEnumerable
    {
        readonly List<Process> Processes = new List<Process>(Process.GetProcesses());

        public IEnumerator GetEnumerator()
        {
            return new ProcessEnumerator(this);
        }

        public List<Process> GetProcesses()
        {
            return Processes;
        }
        public Process this[int index]
        {
            get { return Processes[index]; }
        }
        public int Count
        {
            get { return Processes.Count; }
        }

    }
}
