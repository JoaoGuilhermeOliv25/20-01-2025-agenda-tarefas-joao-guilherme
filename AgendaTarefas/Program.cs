using AgendaTarefas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLitePCL;
using AgendaTarefas.Model;
using AgendaTarefas.Infrastructure.Configuration;

namespace AgendaTarefas
{
    internal static class Program
    {
        public static AppSettings appSettings;

        [STAThread]
        static void Main()
        {
            Batteries.Init(); // Inicia as Baterreies - pacote responsável por funcionar o SQLite da Microsoft
            AUMIDService.Definir("Agenda de Tarefas"); // Define o AppUserModelID para o aplicativo

            Home home = new Home(); // Cria uma instância da classe Home

            appSettings = SettingsManager.CarregarConfig(); // Carrega as configurações do aplicativo
            AplicacaoConfigService configApply = new AplicacaoConfigService();
            configApply.AplicarConfigsSystem(home);

            Application.EnableVisualStyles();
            Application.Run(home);
        }


    }
}
