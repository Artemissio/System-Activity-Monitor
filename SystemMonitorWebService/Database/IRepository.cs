using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitorWebService.Database
{
    public interface IRepository<T> where T : class
    {
        void AddToCollection(T document);
        void RemoveFromCollection(T document);
        void ClearCollection();
        List<T> GetDocuments();
        List<T> GetDocuments(Func<T, bool> expression);
        bool Contains(T document);
    }
}
