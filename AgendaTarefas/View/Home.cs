using AgendaTarefas.Model;
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
            if (lbTitulo.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios antes de criar uma tarefa!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Tarefa novaT = new Tarefa()
            }
        }

    }
}
