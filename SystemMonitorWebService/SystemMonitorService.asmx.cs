using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;
using SystemMonitorWebService.BridgePattern;
using SystemMonitorWebService.Database;
using SystemMonitorWebService.IteratorPattern;
using SystemMonitorWebService.Models;
using SystemMonitorWebService.VisitorPattern;

namespace SystemMonitorWebService
{
    /// <summary>
    /// Сводное описание для SystemMonitorService
    /// </summary>
    [WebService(Namespace = "https://localhost:44390/SystemMonitorService.asmx")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class SystemMonitorService : WebService
    {
        readonly AbstractPerformanceDisplay _memoryDisplay = new MemoryPerformanceDisplay(MemoryPerformanceSingleton.GetInstance());
        readonly AbstractPerformanceDisplay _cpuDisplay = new CpuPerformanceDisplay(CpuPerformanceSingleton.GetInstance());

        //~SystemMonitorService()
        //{
        //    IRepository<Process> repositoryProcess = new SQLIteProcessesRepository();

        //    repositoryProcess.ClearCollection();

        //    IRepository<WindowInfo> repositoryWindowInfo = new SQLiteWindowsRepository();

        //    repositoryWindowInfo.ClearCollection();
        //}

        [WebMethod]
        public List<KeyboardHookModel> GetKeyboardHooks()
        {
            return HookSingleton.GetInstance().GetKeyboardHooks();
        }

        [WebMethod]
        public List<MouseHookModel> GetMouseHooks()
        {
            return HookSingleton.GetInstance().GetMouseHooks();
        }

        [WebMethod]
        public List<Performance> GetMemoryPerformance()
        {
            return _memoryDisplay.GetPerformance();
        }

        [WebMethod]
        public List<Performance> GetCpuPerformance()
        {
            return _cpuDisplay.GetPerformance();
        }

        [WebMethod]
        public List<WindowInfo> GetOpenWindows()
        {
            ObjectStructure objectStructure = new ObjectStructure();
            objectStructure.Add(new ListOfWindowsInfo());
            objectStructure.Accept(new OrderedListVisitor());

            return objectStructure.GetWindows();
        }

        //[WebMethod]
        //public List<Process> GetProcesses()
        //{
        //    List<Process> processes = new List<Process>();
        //    IRepository<Process> repository = new SQLIteProcessesRepository();

        //    IEnumerable enumerable = new ProcessesCollection();
        //    IEnumerator enumerator = enumerable.GetEnumerator();

        //    while (enumerator.MoveNext())
        //    {
        //        Process process = enumerator.Current as Process;
        //        processes.Add(process);

        //        repository.AddToCollection(process);
        //    }

        //    return processes;
        //}

        [WebMethod]
        public List<StatisticsModel> GetMostOpenWindows(int n)
        {
            _ = GetOpenWindows();
            var repository = new SQLiteWindowsRepository();

            return repository.GetMostOpenWindows(n);
        }
    }
}
