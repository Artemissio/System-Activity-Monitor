using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitorWebService.AbstractFactoryPattern
{
    public interface IFactory
    {
        IProduct CreateProduct();
    }
}
