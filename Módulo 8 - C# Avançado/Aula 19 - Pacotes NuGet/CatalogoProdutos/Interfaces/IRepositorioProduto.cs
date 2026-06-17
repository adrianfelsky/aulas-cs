using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoProdutos.Modelos;

namespace CatalogoProdutos.Interfaces
{
    public interface IRepositorioProduto
    {
        public void Adicionar(Produto p);
        //Produto BuscarProdutoPorId(int id);
        List<Produto> ListarTodos();
        List<Produto> BuscarPorCategoria(string categoria);
        Produto BuscarPorId(int id);
    }
}
