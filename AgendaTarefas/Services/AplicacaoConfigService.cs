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

        public void AplicarConfigsSystem()
        {
            NotifyIconService notify = new NotifyIconService();


            if (config.iniciarWindows)
            {
                IniciarComWindows.HabilitarInicializacao();
            }
            else
            {
                IniciarComWindows.DesabilitarInicializacao();
            }


            if (config.mostrarNotificacoes)
            {
                notify.IniciarNotificacoes(config);
            }
            else
            {
                notify.PararNotificacoes();
            }

            // INICIAR MINIMIZADO!!!
        }
    }
}
