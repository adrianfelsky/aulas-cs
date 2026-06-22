using BibliotecaApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Interfaces
{
    public interface IRepositorioLivro
    {
        void Adicionar(Livro livro);

        Livro BuscarPorId(int id);

        List<Livro> ListarTodos();

        List<Livro> BuscarPorAutor(string autor);

    }
}
