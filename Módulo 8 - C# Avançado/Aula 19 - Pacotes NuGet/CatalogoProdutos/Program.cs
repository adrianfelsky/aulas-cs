using CatalogoProdutos.Modelos;
using CatalogoProdutos.Repositorios;

//exercicio1

Produto produto1 = new Produto{Id = 1,Nome = "Smartphone",Categoria = "Eletrônicos",Preco = 1999.99m};
Produto produto2 = new Produto{Id = 2,Nome = "Notebook",Categoria = "Eletrônicos",Preco = 2999.99m};
Produto produto3 = new Produto{Id = 3,Nome = "Cadeira Gamer",Categoria = "Móveis",Preco = 899.99m};
Produto produto4 = new Produto{Id = 4,Nome = "Mesa de Escritório",Categoria = "Móveis",Preco = 1299.99m};
Produto produto5 = new Produto{Id = 5,Nome = "Fone de Ouvido",Categoria = "Eletrônicos",Preco = 299.99m};

List<Produto> produtos = new List<Produto> { produto1, produto2, produto3, produto4, produto5 };

foreach (var produto in produtos)
{
    Console.WriteLine($"\nID: {produto.Id}\n Nome: {produto.Nome}\n Categoria: {produto.Categoria}\n Preço: R${produto.Preco}");
}

//exercicio2

var repositorio = new RepositorioProduto();

repositorio.Adicionar(produto1);
repositorio.Adicionar(produto2);
repositorio.Adicionar(produto3);
repositorio.Adicionar(produto4);
repositorio.Adicionar(produto5);

Console.WriteLine("\n\n--- Buscando categoria: Eletrônicos ---");
var produtosEletronicos = repositorio.BuscarPorCategoria("Eletrônicos");

foreach (var p in produtosEletronicos)
{
    Console.WriteLine($"\nID: {p.Id}\n Nome: {p.Nome}\n Preço: R${p.Preco}");
}