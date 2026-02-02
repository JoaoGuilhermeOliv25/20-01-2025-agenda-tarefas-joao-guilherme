using AgendaTarefas.Model;
using AgendaTarefas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTarefas.Services
{
    public static class FiltroTarefaService
    {
        public static List<Tarefa> TratarFiltro(TipoFiltro tipoF)
        {
            List<Tarefa> tarefasF = new List<Tarefa>();
            switch (tipoF)
            {
                case TipoFiltro.Todas:
                    tarefasF = TabelasDB.ObterTodasTarefas();
                    Home.FiltroAtual = TipoFiltro.Todas;
                    return tarefasF;

                case TipoFiltro.NFinalizadas:
                    tarefasF = TabelasDB.ObterTarefasNFinalizadas();
                    Home.FiltroAtual = TipoFiltro.NFinalizadas;
                    return tarefasF;
                
                case TipoFiltro.Finalizadas:
                    tarefasF = TabelasDB.ObterTarefasFinalizadas();
                    Home.FiltroAtual = TipoFiltro.Finalizadas;
                    return tarefasF;
                
                default:
                    tarefasF = TabelasDB.ObterTodasTarefas();
                    Home.FiltroAtual = TipoFiltro.Todas;
                    return tarefasF;
            }
        }
    }
}
