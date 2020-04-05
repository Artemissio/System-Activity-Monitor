using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Models;
using SystemActivityMonitor.IteratorPattern;

namespace SystemActivityMonitor.ViewModels
{
    public class ProcessesViewModel : IViewModel
    {
        public ObservableCollection<Process> Processes { get; set; } = new ObservableCollection<Process>();

        public ProcessesViewModel()
        {
            IEnumerable enumerable = new ProcessesCollection();
            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Process process = enumerator.Current as Process;
                Processes.Add(process);
            }
        }
    }
}