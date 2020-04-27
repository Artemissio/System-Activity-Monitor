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
                string commandText = "INSERT INTO Windows (ID, Title, Date) VALUES (@ID, @Title, @Date)";

                var command = new SQLiteCommand(commandText, connection);

                command.Parameters.AddWithValue("@ID", document.ID);
                command.Parameters.AddWithValue("@Title", document.Title);
                command.Parameters.AddWithValue("@Date", document.Date);

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

        public override bool Contains(WindowInfo document)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                string commandText = "SELECT COUNT(ID) FROM Windows WHERE ID=@ID AND Title=@Title AND Date=@Date";

                var command = new SQLiteCommand(commandText, connection);

                command.Parameters.AddWithValue("@ID", document.ID);
                command.Parameters.AddWithValue("@Title", document.Title);
                command.Parameters.AddWithValue("@Date", document.Date);

                connection.Open();

                int result = 0;

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result = reader.GetInt32(0);
                }

                return result > 0;
            }
        }

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

        public List<StatisticsModel> GetMostOpenWindows(int n, string startDate, string stopDate)
        {
            List<StatisticsModel> result = new List<StatisticsModel>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                string commandText = "SELECT count(ID) AS Amount, Title FROM Windows WHERE Date";

                if(string.IsNullOrEmpty(stopDate) || string.IsNullOrWhiteSpace(stopDate))
                {
                    commandText += "=@Date ";
                }
                else
                {
                    commandText += " BETWEEN date('now', @StopDate) AND date('now') ";
                }

                commandText += "GROUP BY Title ORDER BY Amount DESC LIMIT @N";

                var command = new SQLiteCommand(commandText, connection);

                if (string.IsNullOrEmpty(stopDate) || string.IsNullOrWhiteSpace(stopDate))
                {
                    command.Parameters.AddWithValue("@Date", startDate);
                }
                else
                {
                    command.Parameters.AddWithValue("@StopDate", stopDate);
                }

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
