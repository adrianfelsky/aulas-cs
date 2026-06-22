using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Excecoes
{
    public class AutorNaoEncontradoException : Exception
    {
        public AutorNaoEncontradoException(string autor)
            : base($"Nenhum livro encontrado para \"{autor}\".") { }

    }
}
