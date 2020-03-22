using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemActivityMonitor.Models
{
    public interface IViewFactory
    {
        void LoadProductivity();
        void LoadWindows();
        void LoadKeyboard();
        void LoadMouse();
        void LoadProcesses();
    }
}