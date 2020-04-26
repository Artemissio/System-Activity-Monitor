using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemMonitorWebService.Models;
using System.Data.SQLite;

namespace SystemMonitorWebService.Database
{
    public class SQLiteWindowsRepository : SQLiteAbstractRepository<WindowInfo>
    {
        public SQLiteWindowsRepository() : base() { }

        public override void AddToCollection(WindowInfo document)
        {
            using(var connection = new SQLiteConnection(ConnectionString))
            {
                string commandText = "INSERT INTO Windows (ID, Title) VALUES (@ID, @Title)";

                var command = new SQLiteCommand(commandText, connection);

                command.Parameters.AddWithValue("@ID", document.ID);
                command.Parameters.AddWithValue("@Title", document.Title);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
        public override void RemoveFromCollection(WindowInfo document)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                string commandText = "DELETE FROM Windows WHERE ID=@ID AND Title=@Title";

                var command = new SQLiteCommand(commandText, connection);

                command.Parameters.AddWithValue("@ID", document.ID);
                command.Parameters.AddWithValue("@Title", document.Title);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public override void ClearCollection()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                string commandText = "DELETE FROM Windows";

                var command = new SQLiteCommand(commandText, connection);
            
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        //public override bool Contains(WindowInfo document)
        //{
        //    using (var connection = new SQLiteConnection(ConnectionString))
        //    {
        //        string commandText = "SELECT * FROM Windows WHERE ID=@ID";

        //        var command = new SQLiteCommand(commandText, connection);

        //        command.Parameters.AddWithValue("@ID", document.ID);

        //        connection.Open();

        //        int result = command.ExecuteReader().FieldCount;

        //        return result >= 1;
        //    }
        //}

        public override List<WindowInfo> GetDocuments()
        {
            List<WindowInfo> result = new List<WindowInfo>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                string commandText = "SELECT * FROM Windows";

                var command = new SQLiteCommand(commandText, connection);
                
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new WindowInfo
                    {
                        ID = reader.GetInt32(0),
                        Title = reader.GetString(1)
                    });
                }

                connection.Close();
            }

            return result;
        }

        public override List<WindowInfo> GetDocuments(Func<WindowInfo, bool> expression)
        {
            return GetDocuments().Where(expression).ToList();
        }       

        public List<StatisticsModel> GetMostOpenWindows(int n)
        {
            List<StatisticsModel> result = new List<StatisticsModel>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                string commandText = "SELECT count(ID) AS Amount, Title FROM Windows GROUP BY Title ORDER BY Amount DESC LIMIT @N; ";

                var command = new SQLiteCommand(commandText, connection);

                command.Parameters.AddWithValue("@N", n);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new StatisticsModel
                    {
                        Amount = reader.GetInt32(0),
                        Title = reader.GetString(1)
                    });
                }

                connection.Close();
            }

            return result;
        }
    }
}
