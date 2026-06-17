using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoProdutos.Interfaces;
using CatalogoProdutos.Modelos;
using CatalogoProdutos.Excecoes;

namespace CatalogoProdutos.Repositorios
{
    public class RepositorioProduto : IRepositorioProduto
    {
        private List<Produto> _produtos = new List<Produto>();
        public void Adicionar(Produto p)
        {
            _produtos.Add(p);
        }
        public List<Produto> ListarTodos()
        {
            return _produtos;
        }
        public List<Produto> BuscarPorCategoria(string categoria)
        {
            //return _produtos.Where(p => p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase)).ToList();
            return _produtos.Where(p => p.Categoria == categoria).ToList();
        }
        public Produto BuscarPorId(int id)
        {
            return _produtos.FirstOrDefault(p => p.Id == id) ?? throw new ProdutoNaoEncontradoException(id);
        }
    }
}
