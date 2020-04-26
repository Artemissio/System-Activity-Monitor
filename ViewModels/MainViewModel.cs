using Caliburn.Micro;

namespace SystemActivityMonitor.ViewModels
{
    public class MainViewModel : Conductor<IViewModel>.Collection.OneActive
    {
        public MainViewModel()
        {
            LoadProcesses();
        }

        public void LoadProductivity()
        {
            ActivateItem(new ProductivityViewModel());
        }

        public void LoadWindows()
        {
            ActivateItem(new WindowsViewModel());
        }

        public void LoadKeyboard()
        {
            ActivateItem(new KeyboardViewModel());
        }

        public void LoadMouse()
        {
            ActivateItem(new MouseViewModel());
        }

        public void LoadProcesses()
        {
            ActivateItem(new ProcessesViewModel());
        }

        public void LoadStatistics()
        {
            ActivateItem(new StatisticsViewModel());
        }
    }
}