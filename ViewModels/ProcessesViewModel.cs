using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Diagnostics;

namespace SystemActivityMonitor.ViewModels
{
    public class ProcessesViewModel : IViewModel
    {
        public ObservableCollection<Process> Processes { get; set; } = new ObservableCollection<Process>();

        public ProcessesViewModel()
        {
            Processes = new ObservableCollection<Process>(Process.GetProcesses());                  
        }
    }
}