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
    }
}
