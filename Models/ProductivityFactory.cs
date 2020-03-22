using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.ViewModels;

namespace SystemActivityMonitor.Models
{
    public class ProductivityFactory : Conductor<IViewModel>, IProductivityFactory
    {
        public virtual void LoadMemory()
        {
            ActivateItem(new MemoryViewModel());
        }

        public virtual void LoadProcessor()
        {
            ActivateItem(new ProcessorViewModel());
        }
    }
}
