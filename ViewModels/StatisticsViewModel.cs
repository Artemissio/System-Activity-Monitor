using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using SystemActivityMonitor.Models;
using SystemActivityMonitor.SystemMonitorWebService;

namespace SystemActivityMonitor.ViewModels
{
    public class StatisticsViewModel : IViewModel, INotifyPropertyChanged
    {
        const string Most = "Most";
        const string OpenWindows = "Frequently Open Windows";
        const string LoadProcesses = "Loaded Processes";
        const string LimitAmount = "Limit Amount";
        const string ChooseDate = "Choose Date:";

        public Dictionary<string, string> PeriodsDictionary { get; set; } = new Dictionary<string, string>
            {
                { "Choose Specific Date", string.Empty },
                { "Last 3 days", "-3 days" },
                { "Last Week", "-7 days" },
                { "Last Month", "-1 month" }
            };

        private string _selectedPeriod;
        public string SelectedPeriod
        {
            get => _selectedPeriod;
            set
            {
                if (_selectedPeriod == value) return;
                _selectedPeriod = value;
                OnPropertyChanged(nameof(SelectedPeriod));

                LoadData();
            }
        }

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

        private string _menuText = string.Empty;
        public string MenuText
        {
            get => _menuText;
            set
            {
                if (_menuText == value) return;
                _menuText = value;
                OnPropertyChanged(nameof(MenuText));
            }
        }

        bool DisplayWindows { get; set; }
        bool DisplayProcesses { get; set; }
        public List<StatisticsModel> TopList { get; set; } = new List<StatisticsModel>();

        private int _amount;
        public int Amount
        {
            get => _amount;
            set
            {
                if (string.IsNullOrEmpty(value.ToString()) || new Regex("[^0-9]+").IsMatch(value.ToString()) || value < 1) return;

                _amount = value;

                OnPropertyChanged(nameof(Amount));
            }
        }

        private int _gridRow;
        public int GridRow
        {
            get => _gridRow;
            set
            {
                if (_gridRow == value) return;

                _gridRow = value;
                OnPropertyChanged(nameof(GridRow));
            }
        }

        private DateTime _date;
        public DateTime Date
        {
            get => _date;
            set
            {
                if (_date == value) return;

                if (string.IsNullOrEmpty(value.ToString()))
                {
                    _date = DateTime.Today;
                }
                else
                {
                    _date = value;
                }

                OnPropertyChanged(nameof(Date));

                if(string.IsNullOrEmpty(SelectedPeriod) || SelectedPeriod == PeriodsDictionary.ElementAt(0).Key)
                {
                    LoadData();
                }
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

        private Visibility _datePicker;
        public Visibility DatePickerVisibility
        {
            get => _datePicker;
            set
            {
                if (_datePicker == value) return;
                _datePicker = value;
                OnPropertyChanged(nameof(DatePickerVisibility));
            }
        }

        string BuildHeader(int amount, string text)
        {
            return $"{amount} {Most} {text}";
        }

        public StatisticsViewModel()
        {
            Amount = 5;
            Date = DateTime.Today;

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
            DatePickerVisibility = Visibility.Visible;
            LoadedProcessesChartVisibility = Visibility.Hidden;

            HeaderText = BuildHeader(Amount, OpenWindows);
            MenuText = LimitAmount + " and " + ChooseDate;

            GridRow = 4;

            TopList = new SystemMonitorService().GetMostOpenWindows(Amount, Date.ToString(DateFormatHolder.yyyyMMdd), SelectedPeriod).ToList();

            OnPropertyChanged(nameof(TopList));
        }

        public void LoadMostLoadedProcesses()
        {
            TopList = new List<StatisticsModel>();

            DisplayWindows = false;
            DisplayProcesses = true;

            LoadedProcessesChartVisibility = Visibility.Visible;
            WindowsChartVisibility = Visibility.Hidden;
            DatePickerVisibility = Visibility.Hidden;

            foreach (var process in Process.GetProcesses())
            {
                TopList.Add(new StatisticsModel
                {
                    Amount = int.Parse((process.PeakWorkingSet64 / 1048576).ToString()),
                    Title = process.ProcessName
                });
            }

            HeaderText = BuildHeader(Amount, LoadProcesses);
            MenuText = LimitAmount + ":";
            GridRow = 2;

            TopList = TopList.OrderByDescending(x => x.Amount).Take(Amount).ToList();

            OnPropertyChanged(nameof(TopList));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
