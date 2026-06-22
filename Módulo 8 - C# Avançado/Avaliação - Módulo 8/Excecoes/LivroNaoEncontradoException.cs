using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Excecoes
{
    public class LivroNaoEncontradoException : Exception
    {
        public LivroNaoEncontradoException(int id)
            : base($"Livro #{id} não encontrado.") { }

    }
}
