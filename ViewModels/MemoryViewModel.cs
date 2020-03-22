using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Models;

namespace SystemActivityMonitor.ViewModels
{
    public class MemoryViewModel : Screen, IViewModel
    {
        ObservableCollection<Performance> performance;
        MemoryPerformanceSingleton performanceSingleton = MemoryPerformanceSingleton.GetInstance();

        public ObservableCollection<Performance> Performance
        {
            get { return performance; }
            set
            {
                performance = value;
                NotifyOfPropertyChange(() => Performance);
            }
        }

        public MemoryViewModel()
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
