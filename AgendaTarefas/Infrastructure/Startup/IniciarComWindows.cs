using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTarefas.Infrastructure.Startup
{
    public static class IniciarComWindows
    {
        private const string AppName = "Agenda Tarefas";


        // Habilita o aplicativo para iniciar com o Windows
        public static void HabilitarInicializacao()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                     @"Software\Microsoft\Windows\CurrentVersion\Run", writable: true))
            {
                key.SetValue(AppName, Assembly.GetExecutingAssembly().Location);
            }
        }


        // Desabilita a inicialização do aplicativo com o Windows
        public static void DesabilitarInicializacao()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                     @"Software\Microsoft\Windows\CurrentVersion\Run", writable: true))
            {
                if (key.GetValue(AppName) != null)
                {
                    key.DeleteValue(AppName);
                }
            }
        }

        
        // Verifica se esta ativado ou não, retorna um bool
        public static bool IsStartupEnabled()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                     @"Software\Microsoft\Windows\CurrentVersion\Run", writable: false))
            {
                return key.GetValue(AppName) != null;
            }
        }
    }
}

