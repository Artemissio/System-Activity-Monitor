using Caliburn.Micro;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SystemActivityMonitor.SystemMonitorWebService;
using SystemMonitorWebService.Models;

namespace SystemActivityMonitor.ViewModels
{
    public class MouseViewModel : Screen, IViewModel
    {
        ObservableCollection<dynamic> mouseHookModels;

        public ObservableCollection<dynamic> MouseEvents
        {
            get { return mouseHookModels; }
            set
            {
                mouseHookModels = value;
                NotifyOfPropertyChange(() => MouseEvents);
            }
        }

        public MouseViewModel()
        {
            _ = UpdateInfo();
        }

        async Task UpdateInfo()
        {
            while (true)
            {
                await Task.Delay(10);
                MouseEvents = new ObservableCollection<dynamic>(HookSingleton.GetInstance().GetMouseHooks());
            }
        }
    }
}
