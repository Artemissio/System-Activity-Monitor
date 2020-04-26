using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemMonitorWebService.Models;

namespace SystemMonitorWebService.Database
{
    public class LiteDbWindowsRepository : LiteDbAbstractRepository<WindowInfo>
    {
        private static readonly string CollectionName = "WindowsCollection";
        public LiteDbWindowsRepository() : base()
        {
            var collection = Database.GetCollection<WindowInfo>(CollectionName);

            collection.EnsureIndex("ID");
        }

        public override void AddToCollection(WindowInfo document)
        {
            using (Database)
            {
                try
                {
                    var collection = Database.GetCollection<WindowInfo>(CollectionName);

                    collection.Insert(document);
                }
                catch (Exception ex)
                {
                    //Database.Rollback();
                    //throw ex;
                }
            }
        }
        public override void RemoveFromCollection(WindowInfo parameter)
        {
            using (Database)
            {
                try
                {
                    var collection = Database.GetCollection<WindowInfo>(CollectionName);

                    bool result = collection.Delete(parameter.ID);
                }
                catch (Exception ex)
                {
                    Database.Rollback();

                    throw ex;
                }
            }
        }

        public override void ClearCollection()
        {
            using (Database)
            {
                try
                {
                    var collection = Database.GetCollection<WindowInfo>(CollectionName);

                    int result = collection.DeleteAll();
                }
                catch (Exception ex)
                {
                    Database.Rollback();

                    throw ex;
                }
            }
        }

        public override List<WindowInfo> GetDocuments()
        {
            using (Database)
            {
                try
                {
                    var collection = Database.GetCollection<WindowInfo>(CollectionName);

                    return collection.FindAll().ToList();
                }
                catch (Exception ex)
                {
                    Database.Rollback();

                    throw ex;
                }
            }
        }

        public override List<WindowInfo> GetDocuments(Func<WindowInfo, bool> expression)
        {
            using (Database)
            {
                try
                {
                    var collection = Database.GetCollection<WindowInfo>(CollectionName);

                    return collection.FindAll().Where(expression).ToList();
                }
                catch (Exception ex)
                {
                    Database.Rollback();

                    throw ex;
                }
            }
        }
    }
}
