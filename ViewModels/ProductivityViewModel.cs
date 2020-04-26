using Caliburn.Micro;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SystemActivityMonitor.SystemMonitorWebService;

namespace SystemActivityMonitor.ViewModels
{
    public class ProductivityViewModel : Conductor<IViewModel>, IViewModel
    {
        private readonly SystemMonitorService Service;

        ObservableCollection<Performance> _memoryPerformance;
        public ObservableCollection<Performance> MemoryPerformance
        {
            get { return _memoryPerformance; }
            set
            {
                _memoryPerformance = value;
                NotifyOfPropertyChange(() => MemoryPerformance);
            }
        }

        ObservableCollection<Performance> _cpuPerformance;
        public ObservableCollection<Performance> CpuPerformance
        {
            get { return _cpuPerformance; }
            set
            {
                _cpuPerformance = value;
                NotifyOfPropertyChange(() => CpuPerformance);
            }
        }

        public ProductivityViewModel()
        {
            Service = new SystemMonitorService();
            _ = UpdateChart();
        }

        async Task UpdateChart()
        {
            while (true)
            {
                await Task.Delay(1000);
                MemoryPerformance = new ObservableCollection<Performance>(Service.GetMemoryPerformance());
                CpuPerformance = new ObservableCollection<Performance>(Service.GetCpuPerformance());
            }
        }
    }
}