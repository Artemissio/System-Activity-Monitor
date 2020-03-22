using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.ViewModels;

namespace SystemActivityMonitor.Models
{
    public static class StaticViewFactory<T> where T : IViewModel, new()
    {
        public static IViewModel Create()
        {
            return new T();
        }
    }
}