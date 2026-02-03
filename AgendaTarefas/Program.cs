using AgendaTarefas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLitePCL;

namespace AgendaTarefas
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Batteries.Init(); // Inicia as Baterreies - pacote responsável por funcionar o SQLite da Microsoft

            AUMIDService.Definir("Agenda de Tarefas"); // Define o AppUserModelID para o aplicativo

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
