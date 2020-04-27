using Caliburn.Micro;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SystemMonitorWebService.Models;

namespace SystemActivityMonitor.ViewModels
{
    public class KeyboardViewModel : Screen, IViewModel
    {
        ObservableCollection<dynamic> keyboardHookModels;

        public ObservableCollection<dynamic> KeyboardEvents
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
                KeyboardEvents = new ObservableCollection<dynamic>(HookSingleton.GetInstance().GetKeyboardHooks());
            }
        }
    }
}
