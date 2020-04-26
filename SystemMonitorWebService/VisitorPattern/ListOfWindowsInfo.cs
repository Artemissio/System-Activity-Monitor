using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemMonitorWebService.Database;
using SystemMonitorWebService.Models;

namespace SystemMonitorWebService.VisitorPattern
{
    public class ListOfWindowsInfo : IElement
    {
        List<WindowInfo> _windows = new List<WindowInfo>();

        public void Accept(IVisitor visitor)
        {
            WindowsStatistics.GetDesktopWindows(out List<WindowInfo> windows);

            _windows = windows;

            try
            {
                IRepository<WindowInfo> repository = new SQLiteWindowsRepository();

                foreach (var window in windows)
                {
                    repository.AddToCollection(window);
                }
            }
            catch (Exception ex) { }

            visitor.VisitWindowsList(this);
        }

        public List<WindowInfo> GetWindows()
        {
            return _windows;
        }
    }
}
