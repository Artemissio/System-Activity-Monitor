using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using SystemActivityMonitor.ViewModels;

namespace SystemActivityMonitor.Models
{
    public class CpuPerformanceSingleton
    {
        List<Performance> Performance;
        static CpuPerformanceSingleton _cpuPerformanceSingleton;
        Timer timer;
        PerformanceCounter theCPUCounter = new PerformanceCounter("Процессор", "% загруженности процессора", "_Total");

        public static CpuPerformanceSingleton GetInstance()
        {
            if (_cpuPerformanceSingleton == null)
                _cpuPerformanceSingleton = new CpuPerformanceSingleton();
            return _cpuPerformanceSingleton;
        }

        CpuPerformanceSingleton()
        {
            Performance = new List<Performance>();

            timer = new Timer(Tick, null, 0, 1000);
        }

        public List<Performance> GetPerformance()
        {
            return Performance;
        }

        void Tick(object e)
        {
            Performance.Add(new Performance
            {
                Time = DateTime.Now,
                Value = theCPUCounter.NextValue()
            });
        }
    }
}
