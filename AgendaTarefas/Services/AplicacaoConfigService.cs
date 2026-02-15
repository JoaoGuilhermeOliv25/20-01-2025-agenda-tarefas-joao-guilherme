using AgendaTarefas.Infrastructure.Configuration;
using AgendaTarefas.Infrastructure.Startup;
using AgendaTarefas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTarefas.Services
{
    public class AplicacaoConfigService
    {
        private AppSettings config = SettingsManager.CarregarConfig();
        NotifyIconService notify = new NotifyIconService();

        public void AplicarConfigsSystem(Home home)
        {
            // Iniciar com Windows
            if (config.iniciarWindows) IniciarComWindows.DesabilitarInicializacao();
            else IniciarComWindows.DesabilitarInicializacao();


            // Mostrar Notificações
            if (config.mostrarNotificacoes) notify.IniciarNotificacoes(config);
            else notify.PararNotificacoes();
            

            // INICIAR MINIMIZADO!!!
            if (config.iniciarMinimizado) home.WindowState = FormWindowState.Minimized;
            else home.WindowState = FormWindowState.Normal;

        }
    }
}
