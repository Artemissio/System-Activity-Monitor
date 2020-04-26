using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitorWebService.VisitorPattern
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
