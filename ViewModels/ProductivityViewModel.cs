using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using SystemActivityMonitor.Models;

namespace SystemActivityMonitor.ViewModels
{
    public class ProductivityViewModel : ProductivityFactory, IViewModel
    {
        public ProductivityViewModel()
        {
            LoadMemory();
        }

        //public override void LoadMemory()
        //{
        //    PerformanceCounter theCPUCounter = new PerformanceCounter("Процессор", "% загруженности процессора", "_Total");

        //    while (true)
        //    {
        //        MessageBox.Show("Процессор загружен на " + theCPUCounter.NextValue().ToString() + "%");
        //        Thread.Sleep(1000);
        //    }
            
        //}
    }
}