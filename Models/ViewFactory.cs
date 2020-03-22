using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.ViewModels;

namespace SystemActivityMonitor.Models
{
    public class ViewFactory : Conductor<IViewModel>.Collection.OneActive, IViewFactory
    {
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