using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Models;

namespace SystemActivityMonitor.AbstractFactoryPattern
{
    public class KeyboardHookFactory : IFactory
    {
        public IProduct CreateProduct()
        {
            return new KeyboardHook();
        }
    }
}
