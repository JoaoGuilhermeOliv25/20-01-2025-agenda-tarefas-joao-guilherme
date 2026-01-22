using System;
using System.Collections.Generic;
using System.Drawing;
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
            this.dataCriacaoT.Text = "Criado no dia " + tarefaUser.DataCriacao.ToString("dd/MM/yyyy");
       
        }


        // Método responsável por formar os componentes da tarefa
        public void FormarTarefa(FlowLayoutPanel flpTarefas)
        {
            Panel painelT = new Panel();

            // Painel da Tarefa
            painelT.Size = new Size(flpTarefas.Width - 8, dataCriacaoT.Height + 130);
            painelT.BorderStyle = BorderStyle.FixedSingle;
            painelT.BackColor = Color.LightGray;
            painelT.Location = new Point(0, 0);
            painelT.Cursor = Cursors.Hand;

            // Título da tarefa
            tituloT.Font = new Font("Segoe UI", 19, FontStyle.Bold);
            tituloT.ForeColor = Color.Black;
            tituloT.AutoSize = true;
            tituloT.Location = new Point(5, 5);

            // Descrição da tarefa

            // Verifica se a descrição é muito longa
            string descExibicao;

            if (descT.Text.Length > 120)
            {
                descExibicao = descT.Text.Substring(0, 121) + "..."; // Mostrar uma parte da descrição apenas
            }
            else
            {
                descExibicao = descT.Text;
            }

            descT.Font = new Font("Segoe UI", 13, FontStyle.Regular);
            descT.ForeColor = Color.DarkSlateGray;
            descT.AutoSize = true;
            descT.MaximumSize = new Size(painelT.Width - 10, 0);
            descT.Location = new Point(5, 45);
            descT.Text = descExibicao;

            // Data de criação da tarefa
            dataCriacaoT.Font = new Font("Segoe UI", 10, FontStyle.Italic);
            dataCriacaoT.ForeColor = Color.DimGray;
            dataCriacaoT.AutoSize = true;
            dataCriacaoT.Location = new Point(5, 115);


            // Adição dos elementos ao painel
            painelT.Controls.Add(tituloT);
            painelT.Controls.Add(descT);
            painelT.Controls.Add(dataCriacaoT);

            flpTarefas.Controls.Add(painelT);

            


        }
    }
}
