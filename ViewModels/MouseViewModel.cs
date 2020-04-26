using Caliburn.Micro;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SystemActivityMonitor.SystemMonitorWebService;

namespace SystemActivityMonitor.ViewModels
{
    public class MouseViewModel : Screen, IViewModel
    {
        ObservableCollection<MouseHookModel> mouseHookModels;

        public ObservableCollection<MouseHookModel> MouseEvents
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
                MouseEvents = new ObservableCollection<MouseHookModel>(new SystemMonitorService().GetMouseHooks());
            }
        }
    }
}
