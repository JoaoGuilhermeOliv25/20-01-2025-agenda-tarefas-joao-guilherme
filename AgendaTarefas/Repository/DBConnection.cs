using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace AgendaTarefas.Repository
{
    public class DBConnection
    {
        // Diretório certo do DB
        private static readonly string PastaApp =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "AgendaTarefas");

        private static readonly string CaminhoBanco =
            Path.Combine(PastaApp, "AgendaTarefas.db");

        private static readonly string connectionString =
            $"Data Source={CaminhoBanco};";

        public static SqliteConnection GetConnection()
        {
            Directory.CreateDirectory(PastaApp);
            return new SqliteConnection(connectionString);
        }

        public static void InicializarBD()
        {
            Directory.CreateDirectory(PastaApp);

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