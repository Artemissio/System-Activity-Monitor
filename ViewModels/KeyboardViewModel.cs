using Caliburn.Micro;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using SystemActivityMonitor.SystemMonitorWebService;

namespace SystemActivityMonitor.ViewModels
{
    public class KeyboardViewModel : Screen, IViewModel
    {
        ObservableCollection<KeyboardHookModel> keyboardHookModels;

        public ObservableCollection<KeyboardHookModel> KeyboardEvents
        {
            get { return keyboardHookModels; }
            set
            {
                keyboardHookModels = value;
                NotifyOfPropertyChange(() => KeyboardEvents);
            }
        }

        public KeyboardViewModel()
        {
            _ = UpdateInfo();
        }

        async Task UpdateInfo()
        {
            while (true)
            {
                await Task.Delay(10);
                KeyboardEvents = new ObservableCollection<KeyboardHookModel>(new SystemMonitorService().GetKeyboardHooks().ToList());
            }
        }
    }
}
