using AgendaTarefas.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTarefas.Model
{
    public class CriarCardTarefa
    {
        // Atributos de UI
        Panel painelT = new Panel();
        Button btnExcluirT = new Button();
        Color corFinalizado = Color.Gray;
        Color corNaoFinalizado = Color.White;

        // Dados do usuário
        Tarefa tarefa;
        Label tituloT = new Label();
        Label descT = new Label();
        public Button finalizadoT = new Button();
        Label dataCriacaoT = new Label();
        public bool finalizado;


        // Construtor da classe
        public CriarCardTarefa(Tarefa tarefaUser)
        {
            // Referenciar a tarefa do usuário
            this.tarefa = tarefaUser;

            // Obter os dados da tarefa criada:
            this.tituloT.Text = tarefaUser.TituloTarefa;
            this.descT.Text = tarefaUser.DescricaoTarefa;
            this.dataCriacaoT.Text = "Criado no dia " + tarefaUser.DataCriacao.ToString("dd/MM/yyyy");
            this.finalizado = tarefaUser.Concluida;
        }


        // Método para formar os componentes da tarefa
        public Panel FormarCardTarefa()
        {
            // Criação dos componentes
            CriarPainelC();
            CriarTituloC();
            CriarDescricaoC();
            CriarDataCriacaoC();
            CriarCheckBoxC();
            CriarExcluirTarefaC();

            // Adição dos elementos ao painel
            painelT.Controls.Add(tituloT);
            painelT.Controls.Add(descT);
            painelT.Controls.Add(dataCriacaoT);
            painelT.Controls.Add(finalizadoT);
            painelT.Controls.Add(btnExcluirT);

            return painelT;
        }




        // COMPONENTES DO CARD DA TAREFA

        // Painel da tarefa - Card
        private void CriarPainelC()
        {
            painelT.Size = new Size(630, dataCriacaoT.Height + 130);
            painelT.BorderStyle = BorderStyle.FixedSingle;
            painelT.BackColor = corNaoFinalizado;
            painelT.Location = new Point(0, 0);
        }


        // Titulo da tarefa
        private void CriarTituloC()
        {
            tituloT.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            tituloT.ForeColor = Color.Black;
            tituloT.AutoSize = true;
            tituloT.Location = new Point(2, 5);
        }


        // Descrição da tarefa
        private void CriarDescricaoC()
        {
            // Verifica se a descrição é muito longa
            string descExibicao;

            if (descT.Text.Length > 120)
            {
                descExibicao = descT.Text.Substring(0, 166) + "...";
            }
            else
            {
                descExibicao = descT.Text;
            }

            descT.Font = new Font("Segoe UI", 13, FontStyle.Regular);
            descT.ForeColor = Color.Black;
            descT.AutoSize = true;
            descT.MaximumSize = new Size((painelT.Width - finalizadoT.Width) - 50, 0);
            descT.Location = new Point(5, 45);
            descT.Text = descExibicao;
        }


        // CheckBox da finalização da tarefa
        private void CriarCheckBoxC()
        {
            if (finalizado)
            {
                finalizadoT.Text = "✔";
                painelT.BackColor = corFinalizado;
                finalizadoT.BackColor = corFinalizado;
                finalizadoT.Enabled = false;
                finalizadoT.Cursor = Cursors.Default;
            }

            finalizadoT.Font = new Font("Segoe UI", 25, FontStyle.Regular);
            finalizadoT.Size = new Size(60, 60);
            finalizadoT.Location = new Point(painelT.Width - 90, (painelT.Height / 2) - 25);
            finalizadoT.AutoSize = false;
            finalizadoT.BackColor = Color.White;
            finalizadoT.FlatAppearance.BorderSize = 2;
            finalizadoT.FlatStyle = FlatStyle.Popup;
            finalizadoT.TextAlign = ContentAlignment.MiddleCenter;
            finalizadoT.Cursor = Cursors.Hand;
            finalizadoT.Click += FinalizadoT_Click;
        }


        // Data de criação da tarefa
        private void CriarDataCriacaoC()
        {
            dataCriacaoT.Font = new Font("Segoe UI", 12, FontStyle.Italic);
            dataCriacaoT.ForeColor = Color.Black;
            dataCriacaoT.AutoSize = true;
            dataCriacaoT.Location = new Point(5, 128);
        }


        // Excluir tarefa 
        private void CriarExcluirTarefaC()
        {
            btnExcluirT.Text = "X";
            btnExcluirT.TextAlign = ContentAlignment.MiddleCenter;
            btnExcluirT.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnExcluirT.Size = new Size(25, 23);
            btnExcluirT.Location = new Point(painelT.Width - 44, 5);
            btnExcluirT.FlatStyle = FlatStyle.Popup;
            btnExcluirT.BackColor = Color.IndianRed;
            btnExcluirT.Cursor = Cursors.Hand;
            btnExcluirT.Click += btnExcluirT_Click;
        }




        // Confirmação de finalização da tarefa - Evento
        private void FinalizadoT_Click(object sender, EventArgs e)
        {
            if (finalizadoT.Text == "")
            {
                var msgResult = MessageBox.Show(
                    "Deseja marcar esta tarefa como finalizada?" +
                    " Ela não poderá ser alterada depois!",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (msgResult == DialogResult.Yes)
                {
                    TabelasDB.ConcluirTarefaDB(tarefa.Id);
                    finalizadoT.Text = "✔";
                    painelT.BackColor = corFinalizado;
                    finalizadoT.BackColor = corFinalizado;
                }


            }
        }



        // Confirmação da exclusão da tarefa - Evento
        private void btnExcluirT_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Tem certeza que deseja excluir essa tarefa?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                painelT.Dispose();
                TabelasDB.ExcluirTarefaDB(tarefa.Id);
            }
        }
    }
}
