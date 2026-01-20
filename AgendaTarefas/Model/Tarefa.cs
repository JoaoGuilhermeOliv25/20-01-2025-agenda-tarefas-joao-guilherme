using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTarefas.Model
{
    public class Tarefa
    {
        private int ID { get; set; }
        private string TituloTarefa { get; set; }
        private string DescricaoTarefa { get; set; }
        private bool Concluida { get; set; }
        private DateTime DataCriacao { get; set; }



        // Contrutor
        public Tarefa(int id, string tituloTarefa, string descricaoTarefa, 
            bool concluida)
        {
            this.ID = id;
            this.TituloTarefa = tituloTarefa;
            this.DescricaoTarefa = descricaoTarefa;
            this.Concluida = false;
            this.DataCriacao = DateTime.Now;
        }




    }
}
