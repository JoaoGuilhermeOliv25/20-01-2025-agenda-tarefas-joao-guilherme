using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTarefas.Model
{
    public class AppSettings
    {
        public bool iniciarWindows { get; set; }
        public bool iniciarMinimizado { get; set; }
        public bool mostrarNotificacoes { get; set; }
        public int tempoNotificacao { get; set; }

        public AppSettings(bool iniciarWindows, bool iniciarMinimizado, bool mostrarNotificacoes, int tempoNotificacao)
        {
            this.iniciarWindows = iniciarWindows;
            this.iniciarMinimizado = iniciarMinimizado;
            this.mostrarNotificacoes = mostrarNotificacoes;
            this.tempoNotificacao = tempoNotificacao;
        }
    }
}
