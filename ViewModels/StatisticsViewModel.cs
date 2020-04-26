using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using SystemActivityMonitor.SystemMonitorWebService;

namespace SystemActivityMonitor.ViewModels
{
    public class StatisticsViewModel : IViewModel, INotifyPropertyChanged
    {
        const string Most = "Most";
        const string OpenWindows = "Open Windows";
        const string LoadProcesses = "Loaded Processes";

        private string _headerText = string.Empty;
        public string HeaderText
        {
            get => _headerText;
            set
            {
                if (_headerText == value) return;
                _headerText = value;
                OnPropertyChanged(nameof(HeaderText));
            }
        }

        //private bool _validAmount;
        //public bool ValidAmount
        //{
        //    get => _validAmount;
        //    set
        //    {
        //        if (_validAmount == value) return;
        //        _validAmount = value;
        //        OnPropertyChanged(nameof(ValidAmount));
        //    }
        //}

        //private string _gridTitle = string.Empty;
        //public string GridTitle
        //{
        //    get => _gridTitle;
        //    set
        //    {
        //        if (_gridTitle == value) return;
        //        _gridTitle = value;
        //        OnPropertyChanged(nameof(GridTitle));
        //    }
        //}

        bool DisplayWindows { get; set; }
        bool DisplayProcesses { get; set; }
        public List<StatisticsModel> TopList { get; set; }

        private int _amount;
        public int Amount
        {
            get => _amount;
            set
            {
                if (string.IsNullOrEmpty(value.ToString()) || new Regex("[^0-9]+").IsMatch(value.ToString()) || value < 0) return;

                _amount = value;

                OnPropertyChanged(nameof(Amount));
            }
        }

        private Visibility _windows;
        public Visibility WindowsChartVisibility
        {
            get => _windows;
            set
            {
                if (_windows == value) return;
                _windows = value;
                OnPropertyChanged(nameof(WindowsChartVisibility));
            }
        }

        private Visibility _processes;
        public Visibility LoadedProcessesChartVisibility
        {
            get => _processes;
            set
            {
                if (_processes == value) return;
                _processes = value;
                OnPropertyChanged(nameof(LoadedProcessesChartVisibility));
            }
        }
               
        string BuildHeader(int amount, string text)
        {
            return $"{amount} {Most} {text}";
        }               

        public StatisticsViewModel()
        {
            Amount = 5;
            LoadWindowsData();
        }

        public void LoadData()
        {
            if (DisplayWindows)
            {
                LoadWindowsData();
            }

            if (DisplayProcesses)
            {
                LoadMostLoadedProcesses();
            }
        }

        public void LoadWindowsData()
        {
            TopList = new List<StatisticsModel>();

            DisplayWindows = true;
            DisplayProcesses = false;

            WindowsChartVisibility = Visibility.Visible;
            LoadedProcessesChartVisibility = Visibility.Hidden;

            HeaderText = BuildHeader(Amount, OpenWindows);
            //GridTitle = "Amount";
            //OnPropertyChanged(nameof(GridTitle));

            TopList = new SystemMonitorService().GetMostOpenWindows(Amount).ToList();

            OnPropertyChanged(nameof(TopList));
        }

        public void LoadMostLoadedProcesses()
        {
            TopList = new List<StatisticsModel>();

            DisplayWindows = false;
            DisplayProcesses = true;

            WindowsChartVisibility = Visibility.Hidden;
            LoadedProcessesChartVisibility = Visibility.Visible;

            foreach(var process in Process.GetProcesses())
            {
                TopList.Add(new StatisticsModel
                {
                    Amount = int.Parse((process.PeakWorkingSet64 / 1048576).ToString()),
                    Title = process.ProcessName
                });
            }

            HeaderText = BuildHeader(Amount, LoadProcesses);

            //GridTitle = "Mb";

            TopList = TopList.OrderByDescending(x => x.Amount).Take(Amount).ToList();

            OnPropertyChanged(nameof(TopList));
            //OnPropertyChanged(nameof(GridTitle));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
