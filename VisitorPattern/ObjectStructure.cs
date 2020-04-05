using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Models;

namespace SystemActivityMonitor.VisitorPattern
{
    public class ObjectStructure
    {
        readonly List<IElement> _elements = new List<IElement>();

        public void Add(IElement acc)
        {
            _elements.Add(acc);
        }

        public void Remove(IElement acc)
        {
            _elements.Remove(acc);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (IElement element in _elements)
                element.Accept(visitor);
        }

        public List<WindowInfo> GetWindows()
        {
            foreach(var element in _elements)
            {
                if(element is ListOfWindowsInfo)
                {
                    var holder = element as ListOfWindowsInfo;

                    return holder.GetWindows();
                }
            }

            return new List<WindowInfo>();
        }
    }
}
