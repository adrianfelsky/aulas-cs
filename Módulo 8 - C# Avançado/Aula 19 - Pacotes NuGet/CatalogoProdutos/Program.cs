using System.IO;
using System.Linq;
using CatalogoProdutos.Excecoes;
using CatalogoProdutos.Modelos;
using CatalogoProdutos.Repositorios;
using CatalogoProdutos.Servicos; // Adicionado para o Exercício 5
using ConsoleTables;
using Newtonsoft.Json;

// exercicio1
Console.WriteLine("\n\nExercício 1 - Listagem de Produtos");
Produto produto1 = new Produto { Id = 1, Nome = "Smartphone", Categoria = "Eletrônicos", Preco = 1999.99m };
Produto produto2 = new Produto { Id = 2, Nome = "Notebook", Categoria = "Eletrônicos", Preco = 2999.99m };
Produto produto3 = new Produto { Id = 3, Nome = "Cadeira Gamer", Categoria = "Móveis", Preco = 899.99m };
Produto produto4 = new Produto { Id = 4, Nome = "Mesa de Escritório", Categoria = "Móveis", Preco = 1299.99m };
Produto produto5 = new Produto { Id = 5, Nome = "Fone de Ouvido", Categoria = "Eletrônicos", Preco = 299.99m };

List<Produto> produtos = new List<Produto> { produto1, produto2, produto3, produto4, produto5 };

foreach (var produto in produtos)
{
    Console.WriteLine($"\nID: #{produto.Id}\n Nome: {produto.Nome}\n Categoria: {produto.Categoria}\n Preço: R${produto.Preco}");
}

// exercicio2
Console.WriteLine("\n\nExercício 2 - Busca por Categoria");
var repositorio = new RepositorioProduto();
repositorio.Adicionar(produto1);
repositorio.Adicionar(produto2);
repositorio.Adicionar(produto3);
repositorio.Adicionar(produto4);
repositorio.Adicionar(produto5);

Console.WriteLine("\n--- Buscando categoria: Eletrônicos ---");
var produtosEletronicos = repositorio.BuscarPorCategoria("Eletrônicos");

foreach (var p in produtosEletronicos)
{
    Console.WriteLine($"\nID: #{p.Id}\n Nome: {p.Nome}\n Preço: R${p.Preco}");
}

// exercicio3
Console.WriteLine("\n\nExercício 3 - Busca por Id");
Console.WriteLine("\n--- Testando Busca por Id ---");

try // id existente
{
    Console.WriteLine("\nBuscando ID #3...");
    var produtoExistente = repositorio.BuscarPorId(3);
    Console.WriteLine($"Produto encontrado: {produtoExistente.Nome}");
}
catch (ProdutoNaoEncontradoException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try // id não existente
{
    Console.WriteLine("\nBuscando ID #99...");
    var produtoFantasma = repositorio.BuscarPorId(99);
    Console.WriteLine($"Produto encontrado: {produtoFantasma.Nome}");
}
catch (ProdutoNaoEncontradoException ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}

// exercicio4
Console.WriteLine("\n\nExercício 4 - Tabela de Produtos");
Console.WriteLine("\n--- Tabela de Produtos (Ordenada por Preço) ---");
var produtosOrdenados = repositorio.ListarTodos().OrderBy(p => p.Preco).ToList();
ExibirTabela(produtosOrdenados);

// exercicio5
Console.WriteLine("\n\nExercício 5 - Serviço Assíncrono com HttpClient");
var cotacaoService = new CotacaoService();

try
{
    Console.WriteLine("\nBuscando cotação do dólar...");
    decimal cotacao = await cotacaoService.ObterCotacaoDolarAsync();
    Console.WriteLine($"Cotação do dólar: R$ {cotacao:F2}");
}
catch (Exception ex)
{
    Console.WriteLine($"\nErro ao buscar cotação: {ex.Message}");
}

Console.WriteLine("\n\nAperte enter para exibir o desafio...\n");
Console.ReadLine();

// desafio
Console.WriteLine("--- Desafio Extra ---");
bool executando = true;

// 2. Loop do Menu Interativo (Desafio EXTRA)
while (executando)
{
    Console.WriteLine("\n==================================");
    Console.WriteLine("       CATÁLOGO DE PRODUTOS       ");
    Console.WriteLine("==================================");
    Console.WriteLine("1. Listar todos os produtos");
    Console.WriteLine("2. Buscar produto por categoria");
    Console.WriteLine("3. Buscar produto por Id");
    Console.WriteLine("4. Ver preços convertidos em dólar");
    Console.WriteLine("5. Salvar catálogo em catalogo.json");
    Console.WriteLine("0. Sair");
    Console.Write("\nEscolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("\n--- Todos os Produtos (Ordenados por Preço) ---");
            var produtosOrdenadosMenu = repositorio.ListarTodos().OrderBy(p => p.Preco).ToList();
            ExibirTabela(produtosOrdenadosMenu);
            break;

        case "2":
            Console.Write("\nDigite a categoria desejada (ex: Eletrônicos, Móveis): ");
            string categoria = Console.ReadLine();
            var produtosCat = repositorio.BuscarPorCategoria(categoria);

            if (produtosCat.Any())
            {
                Console.WriteLine($"\n--- Produtos da categoria: {categoria} ---");
                ExibirTabela(produtosCat);
            }
            else
            {
                Console.WriteLine("\nNenhum produto encontrado nesta categoria.");
            }
            break;

        case "3":
            Console.Write("\nDigite o ID do produto: ");
            if (int.TryParse(Console.ReadLine(), out int idBusca))
            {
                try
                {
                    var pId = repositorio.BuscarPorId(idBusca);
                    Console.WriteLine("\n--- Produto Encontrado ---");
                    ExibirTabela(new List<Produto> { pId });
                }
                catch (ProdutoNaoEncontradoException ex)
                {
                    Console.WriteLine($"\n[ERRO] {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("\n[ERRO] Formato de ID inválido. Digite um número inteiro.");
            }
            break;

        case "4":
            try
            {
                Console.WriteLine("\nConectando à internet para buscar cotação do dólar...");
                decimal cotacao = await cotacaoService.ObterCotacaoDolarAsync();
                Console.WriteLine($"Cotação atual do dólar: R$ {cotacao:F2}\n");

                var produtosDesafio = repositorio.ListarTodos().OrderBy(p => p.Preco).ToList();

                var tableDolar = new ConsoleTable("Id", "Nome", "Categoria", "Preço (R$)", "Preço (US$)");
                foreach (var p in produtosDesafio)
                {
                    tableDolar.AddRow(p.Id, p.Nome, p.Categoria, $"R$ {p.Preco:F2}", $"$ {Math.Round(p.Preco / cotacao, 2):F2}");
                }
                tableDolar.Write();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[ERRO] Falha ao buscar cotação: {ex.Message}");
            }
            break;

        case "5":
            try
            {
                string json = JsonConvert.SerializeObject(repositorio.ListarTodos(), Formatting.Indented);

                string pastaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "CatalogosSalvos");
                string caminhoArquivo = Path.Combine(pastaDestino, "catalogo.json");

                Directory.CreateDirectory(pastaDestino);

                File.WriteAllText(caminhoArquivo, json);

                string caminhoCompleto = Path.GetFullPath(caminhoArquivo);

                Console.WriteLine("\n[SUCESSO] Catálogo salvo com sucesso!");
                Console.WriteLine($"O arquivo foi gerado em: {caminhoCompleto}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[ERRO] Falha ao salvar o arquivo: {ex.Message}");
            }
            break;

        case "0":
            Console.WriteLine("\nSaindo do sistema...");
            executando = false;
            break;

        default:
            Console.WriteLine("\n[ERRO] Opção inválida. Tente novamente.");
            break;
    }
}
static void ExibirTabela(List<Produto> produtos)
{
    var table = new ConsoleTable("Id", "Nome", "Categoria", "Preço");

    foreach (var p in produtos)
    {
        table.AddRow(p.Id, p.Nome, p.Categoria, $"R$ {p.Preco:F2}");
    }

    table.Write();
}