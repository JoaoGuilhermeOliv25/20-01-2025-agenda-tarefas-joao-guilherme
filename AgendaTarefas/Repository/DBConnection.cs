using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AgendaTarefas.Repository
{
    public class DBConnection
    {
        public static string connectionString = "Data Source=AgendaTarefas.db;Version=3;";


        // Conexão com o BD
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
