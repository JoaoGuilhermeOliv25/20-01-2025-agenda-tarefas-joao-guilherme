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

        public Home()
        {
            InitializeComponent();
        }


        // Ao carregar o Form:
        private void Home_Load(object sender, EventArgs e)
        {
            DBConnection.InicializarBD();
            listaTarefas = TabelasDB.ObterTodasTarefas();

            foreach (Tarefa t in listaTarefas)
            {
                CriarCardTarefa criarCardT = new CriarCardTarefa(t);
                flpTarefas.Controls.Add(criarCardT.FormarCardTarefa());
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
                flpTarefas.Controls.Add(novaTarefa.FormarCardTarefa());


                // Mensagem de sucesso
                MessageBox.Show("Tarefa criada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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



        // Limpar Campos
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
    }
}
