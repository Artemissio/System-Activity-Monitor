using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using SystemActivityMonitor.Models;

namespace SystemActivityMonitor.ViewModels
{
    public class ProcessorViewModel : Screen, IViewModel
    {
        ObservableCollection<Performance> performance;
        CpuPerformanceSingleton performanceSingleton = CpuPerformanceSingleton.GetInstance();

        public ObservableCollection<Performance> Performance
        {
            get { return performance; }
            set
            {
                performance = value;
                NotifyOfPropertyChange(() => Performance);
            }
        }

        public ProcessorViewModel()
        {
            _ = UpdateChart();
        }

        async Task UpdateChart()
        {
            while (true)
            {
                await Task.Delay(1000);
                Performance = new ObservableCollection<Performance>(performanceSingleton.GetPerformance());
            }
        }
    }
}