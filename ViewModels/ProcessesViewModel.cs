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

            //Processes = new ObservableCollection<Process>(Process.GetProcesses());
        }

        //public class ProcessData
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public string Window { get; set; }
        //    public DateTime Started { get; set; }
        //    public int Threads { get; set; }
        //    public TimeSpan ProcessorTime { get; set; }
        //    public long Memory { get; set; }
        //}

        //foreach(Process process in Process.GetProcesses())
        //{
        //    Processes.Add(new ProcessData
        //    {
        //        Id = process.Id,
        //        Name = process.ProcessName,
        //        Window = process.MainWindowTitle,
        //        Started = process.StartTime,
        //        Threads = process.Threads.Count,
        //        ProcessorTime = process.TotalProcessorTime,
        //        Memory = process.PeakWorkingSet64 / 1024
        //    });
        //}

    }
}