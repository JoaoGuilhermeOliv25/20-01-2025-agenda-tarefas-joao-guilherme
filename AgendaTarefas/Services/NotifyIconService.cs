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
        Random random = new Random();

        // Construtor
        public NotifyIconService(NotifyIcon notifyIcon)
        {
            this.notifyIcon = notifyIcon;
            notifyIcon.Icon = System.Drawing.SystemIcons.Information;
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "Agenda de Tarefas";

            timer.Interval = 60000;
            timer.Tick += timer_Tick;
        }



        // Iniciar o timer do componente
        public void IniciarNotificacoes()
        {
            timer.Start();
        }


        // Evento do timer
        private void timer_Tick(object sender, EventArgs e)
        {
            Tarefa tarefaSort;
            List<Tarefa> tarefas;

            tarefas = TabelasDB.ObterTarefasNFinalizadas();
            if (tarefas.Count > 0)
            {
                tarefaSort = tarefas[random.Next(0, tarefas.Count)];

                notifyIcon.BalloonTipTitle = "Agenda de Tarefas";
                notifyIcon.ShowBalloonTip(5000, "Tarefas Pendentes!",
                    $"\nA tarefa \"{tarefaSort.TituloTarefa}\" ainda não foi concluída!", ToolTipIcon.Info);
            }
        }

    }
}
