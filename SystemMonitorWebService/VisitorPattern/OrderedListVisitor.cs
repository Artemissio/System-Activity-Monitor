using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemMonitorWebService.IteratorPattern;
using SystemMonitorWebService.Models;

namespace SystemMonitorWebService.VisitorPattern
{
    public class OrderedListVisitor : IVisitor
    {
        public void VisitWindowsList(ListOfWindowsInfo windowsHolder)
        {
            windowsHolder.GetWindows().Sort(new WindowComparer());
        }
    }
}