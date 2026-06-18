using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoProdutos.Excecoes
{
    public class ProdutoNaoEncontradoException : Exception
    {
        public ProdutoNaoEncontradoException(int id) : base($"Produto #{id} não encontrado."){}
    }
}
