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
    public class MouseViewModel : Screen, IViewModel
    {
        ObservableCollection<MouseHookModel> mouseHookModels;

        HookSingleton hookSingleton = HookSingleton.GetInstance();

        //KeyboardMouseHooks.GlobalHook globalHook = KeyboardMouseHooks.GlobalHook.GetInstance();

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
                MouseEvents = new ObservableCollection<MouseHookModel>(hookSingleton.GetMouseHooks());
            }
        }
    }
}
