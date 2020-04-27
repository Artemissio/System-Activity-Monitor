using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using SystemActivityMonitor.SystemMonitorWebService;

namespace SystemActivityMonitor.ViewModels
{
    public class WindowsViewModel : IViewModel, INotifyPropertyChanged
    {
        private List<WindowInfo> _windows;      
        public List<WindowInfo> Windows
        {
            get => _windows;
            set
            {
                if (_windows == value) return;

                _windows = value;
                OnPropertyChanged(nameof(Windows));
            }
        }

        public WindowsViewModel()
        {
            Windows = new SystemMonitorService().GetOpenWindows().ToList();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
