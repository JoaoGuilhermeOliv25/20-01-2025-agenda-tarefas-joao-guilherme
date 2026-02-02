using AgendaTarefas.Model;
using AgendaTarefas.Repository;
using AgendaTarefas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTarefas
{
    public partial class Home : Form
    {
        const int LIMITE = 166;
        List<Tarefa> listaTarefas = new List<Tarefa>();
        Label lbSemTarefa = new Label();
        TipoFiltro tipoF;
        public static TipoFiltro FiltroAtual { get; set; }


        public Home()
        {
            InitializeComponent();
            lbSemTarefa.TextAlign = ContentAlignment.MiddleCenter;
            lbSemTarefa.Size = new Size(flpTarefas.Width - 8, 60);
            lbSemTarefa.Font = new Font("Segoe UI", 14, FontStyle.Regular);
        }



        // Ao carregar o Form:
        private void Home_Load(object sender, EventArgs e)
        {
            DBConnection.InicializarBD();
            tipoF = TipoFiltro.Todas;
            listaTarefas = FiltroTarefaService.TratarFiltro(tipoF);

            if (listaTarefas.Count == 0)
            {
                lbSemTarefa.Visible = true;
                lbSemTarefa.Text = "Nenhuma tarefa criada!";
                flpTarefas.Controls.Add(lbSemTarefa);
            }
            else
            {
                lbSemTarefa.Visible = false;
                foreach (Tarefa t in listaTarefas)
                {
                    CriarCardTarefa criarCardT = new CriarCardTarefa(t);
                    flpTarefas.Controls.Add(criarCardT.FormarCardTarefa());
                }
            }

            NotifyIconService niNotificacao = new NotifyIconService(notifyIcon);
            niNotificacao.IniciarNotificacoes();

        }


        // Validações dos campos
        private void btnCriarTarefa_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarDados validar = new ValidarDados();
                validar.ValidarCampos(lbTitulo.Text, rtDescricao.Text);


                Tarefa novaT = new Tarefa(lbTitulo.Text, rtDescricao.Text, false);

                // Criação das tarefas na interface
                CriarCardTarefa novaTarefa = new CriarCardTarefa(novaT);
                TabelasDB.CriarTarefaDB(novaT);
                flpTarefas.Controls.Clear();
                flpTarefas.Controls.Add(novaTarefa.FormarCardTarefa());
                

                // Mensagem de sucesso
                MessageBox.Show("Tarefa criada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                listaTarefas = FiltroTarefaService.TratarFiltro(tipoF);
                LimparCampos();
            }

            catch (ArgumentException argErro)
            {
                MessageBox.Show("Erro de validação: " + argErro.Message, "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao criar a tarefa: " + erro.Message, "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        // Método responsável por limpar os campos após a criação da tarefa
        private void LimparCampos()
        {
            lbTitulo.Text = "";
            rtDescricao.Text = "";
        }



        // Limitar caracteres na descrição
        private void rtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rtDescricao.TextLength > LIMITE)
            {
                int posicaoCursor = rtDescricao.SelectionStart;

                rtDescricao.Text = rtDescricao.Text.Substring(0, LIMITE);

                // Ajusta o cursor
                rtDescricao.SelectionStart = Math.Min(posicaoCursor, LIMITE);
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Usuário clicou no X
                e.Cancel = true;
                this.Hide();
            }
        }



        // Exibi todas as Tarefas
        private void btnTodasT_Click(object sender, EventArgs e)
        {
            flpTarefas.Controls.Clear(); // Limpar o FlowLayoutPanel
            tipoF = TipoFiltro.Todas;
            listaTarefas = FiltroTarefaService.TratarFiltro(tipoF);

            if (listaTarefas.Count == 0)
            {
                lbSemTarefa.Visible = true;
                lbSemTarefa.Text = "Nenhuma tarefa criada!";
                flpTarefas.Controls.Add(lbSemTarefa);
            }
            else
            {
                lbSemTarefa.Visible = false;
                foreach (Tarefa t in listaTarefas)
                {
                    CriarCardTarefa criarCardT = new CriarCardTarefa(t);
                    flpTarefas.Controls.Add(criarCardT.FormarCardTarefa());
                }
            }

        }

        // Exibi todas as Tarefas Finalizadas
        private void btnNFinalizadas_Click(object sender, EventArgs e)
        {
            flpTarefas.Controls.Clear();
            tipoF = TipoFiltro.NFinalizadas;
            listaTarefas = FiltroTarefaService.TratarFiltro(tipoF);

            if (listaTarefas.Count == 0)
            {
                lbSemTarefa.Visible = true;
                lbSemTarefa.Text = "Nenhuma tarefa esta pendente!";
                flpTarefas.Controls.Add(lbSemTarefa);
            }
            else
            {
                lbSemTarefa.Visible = false;
                foreach (Tarefa t in listaTarefas)
                {
                    CriarCardTarefa criarCardT = new CriarCardTarefa(t);
                    flpTarefas.Controls.Add(criarCardT.FormarCardTarefa());
                }
            }

        }

        // Exibi todas as Tarefas NÃO Finalizadas
        private void btnFinalizadas_Click(object sender, EventArgs e)
        {
            flpTarefas.Controls.Clear();
            tipoF = TipoFiltro.Finalizadas;
            listaTarefas = FiltroTarefaService.TratarFiltro(tipoF);

            if (listaTarefas.Count == 0)
            {
                lbSemTarefa.Visible = true;
                lbSemTarefa.Text = "Nenhuma tarefa foi finalizada!";
                flpTarefas.Controls.Add(lbSemTarefa);
            }
            else
            {
                lbSemTarefa.Visible = false;
                foreach (Tarefa t in listaTarefas)
                {
                    CriarCardTarefa criarCardT = new CriarCardTarefa(t);
                    flpTarefas.Controls.Add(criarCardT.FormarCardTarefa());
                }
            }
        }
    }
}
