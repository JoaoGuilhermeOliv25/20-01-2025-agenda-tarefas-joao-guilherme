using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTarefas.Services
{
    public static class ValidarDados
    {
        // Limite de caracteres
        const int tituloMax = 46;
        const int descMax = 166;


        public static void ValidarCampos(string titulo, string desc)
        {
            if (string.IsNullOrWhiteSpace(titulo))
            {
                throw new ArgumentException("O título da tarefa é obrigatório!");
            }

            else if (titulo.Length > tituloMax)
            {
                throw new ArgumentException($"O título da tarefa não pode exceder {tituloMax} caracteres!");
            }

            else if (desc.Length > descMax)
            {
                throw new ArgumentException($"A descrição da tarefa não pode exceder {descMax} caracteres!");
            }
        }
    }
}
