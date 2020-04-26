using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemMonitorWebService.Models;

namespace SystemMonitorWebService.AbstractFactoryPattern
{
    public class KeyboardHookFactory : IFactory
    {
        public IProduct CreateProduct()
        {
            return new KeyboardHook();
        }
    }
}
