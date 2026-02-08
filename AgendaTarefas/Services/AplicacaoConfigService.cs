using AgendaTarefas.Infrastructure.Configuration;
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

        public void AplicarConfigs()
        {

            if (config.iniciarWindows)
            {
                
            }
            else
            {



            }
        }
    }
}
