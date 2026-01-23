using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTarefas.Services
{
    public class ValidarDados
    {
        public void ValidarCampos(string titulo, string desc)
        {
            if (string.IsNullOrWhiteSpace(titulo))
            {
                throw new ArgumentException("O título da tarefa é obrigatório!");
            }

            else if (titulo.Length > 22)
            {
                throw new ArgumentException("O título da tarefa não pode exceder 22 caracteres!");
            }

            else if (desc.Length > 166)
            {
                throw new ArgumentException("A descrição da tarefa não pode exceder 166 caracteres!");
            }
        }
    }
}
