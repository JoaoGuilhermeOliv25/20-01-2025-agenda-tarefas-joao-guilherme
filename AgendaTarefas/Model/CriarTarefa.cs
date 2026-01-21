using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTarefas.Model
{
    public class CriarTarefa
    {
        Label tituloT = new Label();
        Label descT = new Label();
        CheckBox finalizadoT = new CheckBox();
        Label dataCriacaoT = new Label();

        public CriarTarefa(Tarefa tarefaUser)
        {
            // Obter os dados da tarefa criada:
            this.tituloT.Text = tarefaUser.TituloTarefa;
            this.descT.Text = tarefaUser.DescricaoTarefa;
            this.finalizadoT.Checked = tarefaUser.Concluida;
            this.dataCriacaoT.Text = tarefaUser.DataCriacao.ToString("dd/MM/yyyy HH:mm");
        

        }
    }
}
