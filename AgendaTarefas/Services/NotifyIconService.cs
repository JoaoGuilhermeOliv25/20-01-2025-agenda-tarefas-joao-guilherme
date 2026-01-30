using AgendaTarefas.Model;
using AgendaTarefas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTarefas.Services
{
    public class NotifyIconService
    {
        NotifyIcon notifyIcon = new NotifyIcon();
        Timer timer = new Timer();

        // Construtor
        public NotifyIconService()
        {
            notifyIcon.Icon = System.Drawing.SystemIcons.Information;
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "Agenda de Tarefas";

            timer.Interval = 4 * 60 * 60 * 1000;
            timer.Tick += timer_Tick;
        }

        // Iniciar o timer do componente
        public void IniciarNotificacoes()
        {
            timer.Start();
        } 


        private void timer_Tick(object sender, EventArgs e)
        {
            Tarefa tarefaSort;
            List<Tarefa> tarefas;
            
            tarefas = TabelasDB.ObterTarefasNFinalizadas();
            if (tarefas.Count > 0)
            {
                Random random = new Random();
                tarefaSort = tarefas[random.Next(0, tarefas.Count)];

                notifyIcon.ShowBalloonTip(5000, "Tarefas Pendentes!\n", 
                    $"A tarefa \"{tarefaSort.TituloTarefa}\" ainda não foi concluída!", ToolTipIcon.Info);
            }

            
        }
    }
}
