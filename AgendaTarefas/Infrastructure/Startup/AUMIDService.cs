using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTarefas.Services
{
    public static class AUMIDService
    {
        [DllImport("shell32.dll", SetLastError = true)]
        private static extern int SetCurrentProcessExplicitAppUserModelID(
            [MarshalAs(UnmanagedType.LPWStr)] string appID);


        // Defini o título do aplicativo na barra de tarefas do Windows
        public static void Definir(string appId)
        {
            SetCurrentProcessExplicitAppUserModelID(appId);
        }
       
    }
}
