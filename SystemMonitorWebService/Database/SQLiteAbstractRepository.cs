using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitorWebService.Database
{
    public abstract class SQLiteAbstractRepository<T> : IRepository<T> where T : class
    {
        protected readonly string ConnectionString;

        public SQLiteAbstractRepository()
        {
            ConnectionString = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + @"db\LocalSQLiteDB.db";

            //ConnectionString = ConfigurationManager.ConnectionStrings["LocalSQLiteDB"].ConnectionString?.Replace("*", Directory.GetCurrentDirectory());
        }
        
        public abstract void AddToCollection(T document);
        public abstract void ClearCollection();
        public abstract bool Contains(T document);
        public abstract List<T> GetDocuments();
        public abstract List<T> GetDocuments(Func<T, bool> expression);
        public abstract void RemoveFromCollection(T document);
    }
}
