using Caliburn.Micro;
using System;
using System.Collections.Generic;
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
    public class ProductivityViewModel : Conductor<IViewModel>, IViewModel
    {
        readonly AbstractPerformanceDisplay _memoryDisplay = new MemoryPerformanceDisplay(MemoryPerformanceSingleton.GetInstance());
        readonly AbstractPerformanceDisplay _cpuDisplay = new CpuPerformanceDisplay(CpuPerformanceSingleton.GetInstance());

        public ProductivityViewModel()
        {
            LoadMemory();
        }

        public virtual void LoadMemory()
        {
            ActivateItem(new MemoryViewModel(_memoryDisplay));
        }

        public virtual void LoadProcessor()
        {
            ActivateItem(new ProcessorViewModel(_cpuDisplay));
        }
    }
}