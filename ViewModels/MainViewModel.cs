using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.BridgePattern;
using SystemActivityMonitor.Models;

namespace SystemActivityMonitor.ViewModels
{
    public class MainViewModel : Conductor<IViewModel>.Collection.OneActive
    {
        private readonly HookSingleton _hookSingleton;
        readonly AbstractPerformanceDisplay _display;

        public MainViewModel()
        {
            _hookSingleton = HookSingleton.GetInstance();

            LoadProcesses();
        }

        public void LoadProductivity()
        {
            ActivateItem(new ProductivityViewModel());
        }

        public void LoadWindows()
        {
            ActivateItem(new WindowsViewModel());
        }

        public void LoadKeyboard()
        {
            ActivateItem(new KeyboardViewModel());
        }

        public void LoadMouse()
        {
            ActivateItem(new MouseViewModel());
        }

        public void LoadProcesses()
        {
            ActivateItem(new ProcessesViewModel());
        }
    }
}