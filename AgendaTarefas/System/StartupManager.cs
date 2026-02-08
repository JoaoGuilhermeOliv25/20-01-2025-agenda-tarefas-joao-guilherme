using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTarefas.System
{
    public static class StartupManager
    {
        private const string appNome = "Agenda Tarefas";

        public static void HabilitarInicializacao()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                 @"Software\Microsoft\Windows\CurrentVersion\Run", true))
            {
                key.SetValue(appNome, Assembly.GetExecutingAssembly().Location);
            }
        }


        public static void DisableStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Run", true))
            {
                if (key.GetValue(appNome) != null)
                    key.DeleteValue(appNome);
            }
        }


        // Verifica se esta hanilitado ou não, retorna um bool
        public static bool VerificarEstado()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Run", false))
            {
                return key.GetValue(appNome) != null;
            }
        }
    }
}
