using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Models;

namespace SystemActivityMonitor.ViewModels
{
    public class MainViewModel : ViewFactory
    {
        private readonly HookSingleton hookSingleton;

        public MainViewModel()
        {
            hookSingleton = HookSingleton.GetInstance();

            LoadProcesses();
        }
    }
}