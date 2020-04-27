using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace SystemMonitorWebService.Database
{
    public abstract class LiteDbAbstractRepository<T> : IRepository<T> where T : class
    {
        readonly string ConnectionString;

        protected readonly LiteDatabase Database;

        protected LiteDbAbstractRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["LocalLiteDB"].ConnectionString.Replace("*", Directory.GetCurrentDirectory());

            Database = new LiteDatabase(ConnectionString);
        }
        public abstract void AddToCollection(T document);
        public abstract void ClearCollection();
        public abstract List<T> GetDocuments();
        public abstract List<T> GetDocuments(Func<T, bool> expression);
        public abstract void RemoveFromCollection(T parameter);
        public abstract bool Contains(T document);
    }
}
