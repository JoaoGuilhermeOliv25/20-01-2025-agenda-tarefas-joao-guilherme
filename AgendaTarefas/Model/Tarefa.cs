using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTarefas.Model
{
    public class Tarefa
    {
        public string TituloTarefa { get; set; }
        public string DescricaoTarefa { get; set; }
        public bool Concluida { get; set; }
        public DateTime DataCriacao { get; set; }



        // Contrutor
        public Tarefa(string tituloTarefa, string descricaoTarefa, 
            bool concluida)
        {
            this.TituloTarefa = tituloTarefa;
            this.DescricaoTarefa = descricaoTarefa;
            this.Concluida = false;
            this.DataCriacao = DateTime.Now;
        }




    }
}
