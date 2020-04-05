using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.BridgePattern;
using SystemActivityMonitor.Models;
using MemoryPerformanceSingleton = SystemActivityMonitor.BridgePattern.MemoryPerformanceSingleton;

namespace SystemActivityMonitor.ViewModels
{
    public class MemoryViewModel : Screen, IViewModel
    {
        ObservableCollection<Performance> _performance;
        readonly AbstractPerformanceDisplay _display;

        public ObservableCollection<Performance> Performance
        {
            get { return _performance; }
            set
            {
                _performance = value;
                NotifyOfPropertyChange(() => Performance);
            }
        }

        public MemoryViewModel(AbstractPerformanceDisplay display)
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
