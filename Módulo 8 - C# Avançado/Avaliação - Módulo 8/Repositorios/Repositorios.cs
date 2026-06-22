using BibliotecaApp.Excecoes;
using BibliotecaApp.Interfaces;
using BibliotecaApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Repositorios
{
    public class RepositorioLivro : IRepositorioLivro
    {
        private List<Livro> _livros = new List<Livro>();

        public void Adicionar(Livro livro)
        {
            _livros.Add(livro);
        }
        public List<Livro> ListarTodos()
        {
            return _livros.OrderBy(l => l.Titulo).ToList();
        }
        public Livro BuscarPorId(int id)
        {
            Livro livro = _livros.FirstOrDefault(l => l.ID == id);
            return livro ?? throw new LivroNaoEncontradoException(id);
        }
        public List<Livro> BuscarPorAutor(string autor)
        {
            return _livros
                .Where(l => l.Autor.ToLower().Contains(autor.ToLower()))
                .ToList();
        }

        public async Task<List<Livro>> ListarDisponiveisAsync()
        {
            await Task.Delay(500);

            return _livros
                .Where(l => l.Disponivel)
                .OrderBy(l => l.Titulo)
                .ToList();
        }
    }
}

