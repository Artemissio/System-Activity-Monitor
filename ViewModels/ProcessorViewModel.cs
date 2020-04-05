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
using SystemActivityMonitor.BridgePattern;
using SystemActivityMonitor.Models;

namespace SystemActivityMonitor.ViewModels
{
    public class ProcessorViewModel : Screen, IViewModel
    {
        ObservableCollection<Performance> performance;
        readonly AbstractPerformanceDisplay _display;

        public ObservableCollection<Performance> Performance
        {
            get { return performance; }
            set
            {
                performance = value;
                NotifyOfPropertyChange(() => Performance);
            }
        }

        public ProcessorViewModel(AbstractPerformanceDisplay display)
        {
            _display = display;
            _ = UpdateChart();
        }

        async Task UpdateChart()
        {
            while (true)
            {
                await Task.Delay(1000);
                Performance = new ObservableCollection<Performance>(_display.GetPerformance());
            }
        }
    }
}