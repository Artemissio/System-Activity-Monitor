using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using SystemActivityMonitor.ViewModels;

namespace SystemActivityMonitor.Models
{
    public class MemoryPerformanceSingleton
    {
        static MemoryPerformanceSingleton _memoryPerformance;

        List<Performance> Performance;
        Timer timer;

        PerformanceCounter theCPUCounter = new PerformanceCounter("Memory", "Available MBytes");

        public static MemoryPerformanceSingleton GetInstance()
        {
            if (_memoryPerformance == null)
                _memoryPerformance = new MemoryPerformanceSingleton();
            return _memoryPerformance;
        }

        MemoryPerformanceSingleton()
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
