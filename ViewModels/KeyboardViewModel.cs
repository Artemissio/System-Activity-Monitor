using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Models;

namespace SystemActivityMonitor.ViewModels
{
    public class KeyboardViewModel : Screen, IViewModel
    {
        ObservableCollection<KeyboardHookModel> keyboardHookModels;

        HookSingleton hookSingleton = HookSingleton.GetInstance();

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
                KeyboardEvents = new ObservableCollection<KeyboardHookModel>(hookSingleton.GetKeyboardHooks());
            }
        }
    }
}
