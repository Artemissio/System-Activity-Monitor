using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Models;
using SystemActivityMonitor.VisitorPattern;

namespace SystemActivityMonitor.ViewModels
{
    public class WindowsViewModel : IViewModel
    {
        public List<WindowInfo> Windows { get; set; } = new List<WindowInfo>();

        public WindowsViewModel()
        {
            ObjectStructure objectStructure = new ObjectStructure();
            objectStructure.Add(new ListOfWindowsInfo());
            objectStructure.Accept(new OrderedListVisitor());

            Windows = objectStructure.GetWindows();
        }
    }
}
