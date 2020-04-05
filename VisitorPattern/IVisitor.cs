using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Models;

namespace SystemActivityMonitor.VisitorPattern
{
    public interface IVisitor
    {
        void VisitWindowsList(ListOfWindowsInfo windowsHolder);
    }
}