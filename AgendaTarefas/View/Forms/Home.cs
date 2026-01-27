using AgendaTarefas.Model;
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

        public Home()
        {
            InitializeComponent();
            
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
                flpTarefas.Controls.Add(novaTarefa.FormarCardTarefa());


                // Mensagem de sucesso
                MessageBox.Show("Tarefa criada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
