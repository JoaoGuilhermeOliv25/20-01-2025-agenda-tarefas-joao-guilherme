using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace AgendaTarefas.Repository
{
    public class DBConnection
    {
        public static string connectionString = "Data Source=AgendaTarefas.db;";


        // Conexão com o BD
        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }

        public static void InicializarBD()
        {
            // Verifica se o BD existe
            using (var connection = GetConnection())
            {
                connection.Open();
                string criarTabelaTarefas = @"
                CREATE TABLE IF NOT EXISTS Tarefas (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Titulo TEXT NOT NULL,
                    Descricao TEXT,
                    Concluida BOOLEAN NOT NULL,
                    DataCriacao DATETIME NOT NULL
                );";

                using (var command = new SqliteCommand(criarTabelaTarefas, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
