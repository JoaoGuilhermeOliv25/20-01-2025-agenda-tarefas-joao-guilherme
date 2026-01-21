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
        List<string> tarefas = new List<string>() { 
            "Estudar C#", 
            "Estudar Java", 
            "Web Dev" 
        };
        

        public Home()
        {
            InitializeComponent();
            
            /*
            Label tituloT = new Label();
            Label descT = new Label();
            CheckBox finalizadoT = new CheckBox();

            Panel tarefa = new Panel();


            // Panel (card da tarefa)
            tarefa.Width = 585;
            tarefa.Height = 100;
            tarefa.BorderStyle = BorderStyle.FixedSingle;


            // Texto
            tituloT.Text = "Minhas Tarefas";
            descT.Text = "Lista de tarefas pendentes";
            finalizadoT.Checked = false;

            // Layout dos labels
            tituloT.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            tituloT.Location = new Point(10, 5);
            tituloT.AutoSize = true;

            descT.Location = new Point(10, 30);
            descT.AutoSize = true;

            // Checkbox à direita
            finalizadoT.Location = new Point(tarefa.Width - 100, tarefa.Height / 2);

            

            // Adiciona controles no Panel
            tarefa.Controls.Add(tituloT);
            tarefa.Controls.Add(descT);
            tarefa.Controls.Add(finalizadoT);

            // Adiciona o Panel no FlowLayoutPanel
            flpTarefas.Controls.Add(tarefa);
            */

        }



        
    }
}
