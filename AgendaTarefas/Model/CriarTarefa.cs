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
        Panel painelT = new Panel();

        Label tituloT = new Label();
        Label descT = new Label();
        Button finalizadoT = new Button();
        Label dataCriacaoT = new Label();

        public CriarTarefa(Tarefa tarefaUser)
        {
            // Obter os dados da tarefa criada:
            this.tituloT.Text = tarefaUser.TituloTarefa;
            this.descT.Text = tarefaUser.DescricaoTarefa;
            this.dataCriacaoT.Text = "Criado no dia " + tarefaUser.DataCriacao.ToString("dd/MM/yyyy");
       
        }


        // Método responsável por formar os componentes da tarefa
        public void FormarTarefa(FlowLayoutPanel flpTarefas)
        {

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

            // CheckBox da finalização da tarefa
            finalizadoT.Text = "";
            finalizadoT.Font = new Font("Segoe UI", 25, FontStyle.Regular);
            finalizadoT.Size = new Size(60, 60);
            finalizadoT.Location = new Point(painelT.Width - 90, (painelT.Height / 2) - 30);
            finalizadoT.AutoSize = false;
            finalizadoT.BackColor = Color.LightGray;
            finalizadoT.FlatAppearance.BorderSize = 2;
            finalizadoT.FlatStyle = FlatStyle.Popup;
            finalizadoT.TextAlign = ContentAlignment.MiddleCenter;
            finalizadoT.Click += FinalizadoT_Click; // Evento do click


            // Adição dos elementos ao painel
            painelT.Controls.Add(tituloT);
            painelT.Controls.Add(descT);
            painelT.Controls.Add(dataCriacaoT);
            painelT.Controls.Add(finalizadoT);


            flpTarefas.Controls.Add(painelT);

            


        }


        // Confirmação de finalização da tarefa - Evento
        private void FinalizadoT_Click(object sender, EventArgs e)
        {
            if (finalizadoT.Text == "")
            {
                var msgResult = MessageBox.Show("Deseja marcar esta tarefa como finalizada?" +
                    " Ela não poderá ser alterada depois!", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msgResult == DialogResult.Yes)
                {
                    finalizadoT.Text = "✔";
                    finalizadoT.ForeColor = Color.Green;
                }
                
                painelT.Enabled = false;

            }
        }
    }
}
