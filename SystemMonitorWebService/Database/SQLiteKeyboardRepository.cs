using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemMonitorWebService.Models;

namespace SystemMonitorWebService.Database
{
    public class SQLiteKeyboardRepository : SQLiteAbstractRepository<KeyboardHookModel>
    {
        public SQLiteKeyboardRepository() : base() { }

        public override void AddToCollection(KeyboardHookModel document)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                string commandText = "INSERT INTO KeyboardHooks (EventType, KeyChar) VALUES (@EventType, @KeyChar)";

                var command = new SQLiteCommand(commandText, connection);

                command.Parameters.AddWithValue("@EventType", document.EventType);
                command.Parameters.AddWithValue("@KeyChar", document.KeyChar);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public override void RemoveFromCollection(KeyboardHookModel document)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                string commandText = "DELETE * FROM KeyboardHooks WHERE EventType=@EventType AND KeyChar=@KeyChar";

                var command = new SQLiteCommand(commandText, connection);

                command.Parameters.AddWithValue("@EventType", document.EventType);
                command.Parameters.AddWithValue("@KeyChar", document.KeyChar);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public override void ClearCollection()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                string commandText = "DELETE FROM KeyboardHooks";

                var command = new SQLiteCommand(commandText, connection);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public override List<KeyboardHookModel> GetDocuments()
        {
            List<KeyboardHookModel> result = new List<KeyboardHookModel>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                string commandText = "SELECT * FROM KeyboardHooks";

                var command = new SQLiteCommand(commandText, connection);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new KeyboardHookModel
                    {
                        EventType = reader.GetString(0),
                        KeyChar = reader.GetString(1)
                    });
                }

                connection.Close();
            }

            return result;
        }

        public override List<KeyboardHookModel> GetDocuments(Func<KeyboardHookModel, bool> expression)
        {
            return GetDocuments().Where(expression).ToList();
        }        
    }
}
