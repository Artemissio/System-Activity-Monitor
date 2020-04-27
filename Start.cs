using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using SystemActivityMonitor.ViewModels;
using SystemMonitorWebService.Models;

namespace SystemActivityMonitor
{
    public class Start : BootstrapperBase
    {
        public Start()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();

            HookSingleton.GetInstance();
        }
    }
}