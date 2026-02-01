using AgendaTarefas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AgendaTarefas.Repository
{
    public class TabelasDB
    {
        // Método para Inserir uma nova tarefa no BD
        public static void CriarTarefaDB(Tarefa tarefa)
        {
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();

                string sql = @"
                    INSERT INTO Tarefas 
                    (Titulo, Descricao, Concluida, DataCriacao)
                    VALUES 
                    (@Titulo, @Descricao, @Concluida, @DataCriacao);
                    ";

                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Titulo", tarefa.TituloTarefa);
                    cmd.Parameters.AddWithValue("@Descricao", tarefa.DescricaoTarefa);
                    cmd.Parameters.AddWithValue("@Concluida", tarefa.Concluida ? 1 : 0);
                    cmd.Parameters.AddWithValue("@DataCriacao", tarefa.DataCriacao);

                    cmd.ExecuteNonQuery();

                    // PEGAR O ID GERADO
                    tarefa.Id = (int)connection.LastInsertRowId;
                }
            }
        }


        // Método para obter todas as tarefas já criadas
        public static List<Tarefa> ObterTodasTarefas()
        {
            List<Tarefa> tarefas = new List<Tarefa>();
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                string sql = "SELECT Id, Titulo, Descricao, Concluida, DataCriacao FROM Tarefas";
                
                using (var cmd = new SQLiteCommand(sql, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tarefa tarefa = new Tarefa(
                            reader["Titulo"].ToString(),
                            reader["Descricao"].ToString(),
                            Convert.ToInt32(reader["Concluida"]) == 1
                        );

                        tarefa.Id = Convert.ToInt32(reader["Id"]);
                        tarefa.DataCriacao = Convert.ToDateTime(reader["DataCriacao"]);

                        tarefas.Add(tarefa);
                    }
                }
            }

            return tarefas;
        }



        // Método para marcar uma tarefa como concluída no BD 
        public static void ConcluirTarefaDB(int tarefaId)
        {
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                string sql = "UPDATE Tarefas SET Concluida = 1 WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", tarefaId);
                    cmd.ExecuteNonQuery();
                }
            }
        }



        // Método para excluir uma tarefa do BD
        public static void ExcluirTarefaDB(int tarefaId)
        {
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                string sql = "DELETE FROM Tarefas WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", tarefaId);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        // Método para obter todas as tarefas não finalizadas
        public static List<Tarefa> ObterTarefasNFinalizadas()
        {
            using (var conneciton = DBConnection.GetConnection())
            {
                conneciton.Open();
                string sql = "SELECT * FROM Tarefas WHERE Concluida = 0";

                using (var cmd = new SQLiteCommand(sql, conneciton))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        List<Tarefa> tarefas = new List<Tarefa>();
                        while (reader.Read())
                        {
                            Tarefa tarefa = new Tarefa(
                                reader["Titulo"].ToString(),
                                reader["Descricao"].ToString(),
                                Convert.ToInt32(reader["Concluida"]) == 1
                            );
                            tarefa.Id = Convert.ToInt32(reader["Id"]);
                            tarefa.DataCriacao = Convert.ToDateTime(reader["DataCriacao"]);
                            tarefas.Add(tarefa);
                        }
                        return tarefas;
                    }
                }
            }
        }
    }
}
