using aula16;

void ExibirDicionario(Dictionary<string, object> dicionario)
{
    foreach (var (nome, valor) in dicionario)
    {
        Console.WriteLine(nome + ":");
        if (valor is IEnumerable<Produto> enumerableProdutos)
        {
            foreach (var produto in enumerableProdutos)
            {
                Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}");
            }
        }
        else if (valor is IEnumerable<string> enumerableNomes)
        {
            foreach (var item in enumerableNomes)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine(valor);
        }
    }
}

//exercicio1
var nomes = new List<string> { "primeiro", "segundo", "terceiro", "quarto", "quinto" };

nomes.Add("sexto");
nomes.Add("sétimo");

nomes.Remove(nomes[1]);

Console.WriteLine(nomes.Count());
foreach(var nome in nomes)
{
    Console.WriteLine(nome);
}

//exercicio2
var frutas = new Dictionary<string, int>()
{
    {"maça",3},
    {"banana",7},
    {"laranja",5}
};

frutas["uva"]=10;
Console.WriteLine(frutas["banana"]);
Console.WriteLine(frutas.ContainsKey("manga"));

foreach (var fruta in frutas)
{
    //Console.WriteLine(fruta);
    Console.WriteLine($"Fruta: {fruta.Key}, Quantidade: {fruta.Value}");
}

//exercicio3
/*List<int>*/var numeros = new List<int> { 4, 17, 3, 22, 9, 31, 6, 14, 23 };

List<int> maior10 = numeros.Where(x => x > 10).ToList();
List<int> par = numeros.Where(x => x % 2 == 0).ToList();
int maior15 = numeros.Count(x => x > 15);

var lista1 = new Dictionary<string, object>
    {
       {nameof(numeros), numeros },
       {nameof(maior10), maior10 },
       {nameof(par), par },
       {nameof(maior15), maior15}
    };

ExibirDicionario(lista1);

//exercicio4
List<string> nomes2 = new List<string> { "ana", "carlos", "beatriz", "diego", "eva" };
var maiusculo = nomes2.Select(x => x.ToUpper());
var ordenado = nomes2.OrderBy(x => x);
var antiOrdenado = nomes2.OrderByDescending(x => x);

var lista2 = new Dictionary<string, object>
    {
       {nameof(nomes2), nomes2 },
       {nameof(maiusculo), maiusculo },
       {nameof(ordenado), ordenado },
       {nameof(antiOrdenado), antiOrdenado}
    };

ExibirDicionario(lista2);

//exercicio5

var produtos = new List<Produto>
{
    new Produto{Nome="Notebook",Preco= 2500.00},
    new Produto{Nome="Smartphone", Preco= 1500.00 },
    new Produto{Nome="Tablet", Preco=800.00 },
    new Produto{Nome="Monitor", Preco=1200.00 },
    new Produto{Nome="Teclado", Preco=200.00 },
    new Produto{Nome="Mouse", Preco= 100.00 }
};

var produtosAcima300 = produtos.Where(p => p.Preco > 300).ToList();
var produtosOrdenados = produtos.OrderBy(p => p.Nome).ToList();
var produtosNomes = produtos.Select(p => p.Nome).ToList();

var lista3 = new Dictionary<string, object>
    {
       {nameof(produtos), produtos },
       {nameof(produtosAcima300), produtosAcima300 },
       {nameof(produtosOrdenados), produtosOrdenados },
       {nameof(produtosNomes), produtosNomes}
    };

ExibirDicionario(lista3);

Console.WriteLine("Soma dos valores: " + produtos.Sum(x => x.Preco));
Console.WriteLine("Média dos valores: " + produtos.Average(x=>x.Preco));

//desafio

var produtos2 = new List<Produto>()
{
    new Produto {
            Id = 1,
            Nome = "Notebook",
            Categoria = "Eletrônicos",
            Preco = 2500.00,
            Estoque = 10
    },
    new Produto {
            Id = 2,
            Nome = "Smartphone",
            Categoria = "Eletrônicos",
            Preco = 1500.00,
            Estoque = 4
    },
    new Produto {
            Id = 3,
            Nome = "Tablet",
            Categoria = "Eletrônicos",
            Preco = 800.00,
            Estoque = 4
    },
    new Produto {
            Id = 4,
            Nome = "Monitor",
            Categoria = "Eletrônicos",
            Preco = 1200.00,
            Estoque = 2
    },
    new Produto {
            Id = 5,
            Nome = "Teclado",
            Categoria = "Periféricos",
            Preco = 200.00,
            Estoque = 7
    },
    new Produto {
            Id = 6,
            Nome = "Mouse",
            Categoria = "Periféricos",
            Preco = 100.00,
            Estoque = 15
    },
    new Produto {
            Id = 7,
            Nome = "Cadeira Gamer",
            Categoria = "Móveis",
            Preco = 900.00,
            Estoque = 2
    },
    new Produto {
            Id = 8,
            Nome = "Mesa Gamer",
            Categoria = "Móveis",
            Preco = 1200.00,
            Estoque = 1
    }
};

var produtosReposicao = produtos2.Where(x => x.Estoque < 5).ToList();
var produtoMaisCaro = produtos2.OrderByDescending(x => x.Preco).FirstOrDefault();
var produtoMaisBarato = produtos2.OrderBy(x => x.Preco).FirstOrDefault();
var valorTotalEstoque = produtos2.Sum(x => x.Preco * x.Estoque);
var prdoutosMaisCarosTop3 = produtos2.OrderByDescending(x => x.Preco).Take(3).ToList();

var lista4 = new Dictionary<string, object>
    {
       {nameof(produtos2), produtos2 },
       {nameof(produtosReposicao), produtosReposicao },
       {nameof(produtoMaisCaro), produtoMaisCaro },
       {nameof(produtoMaisBarato), produtoMaisBarato},
       {nameof(valorTotalEstoque), valorTotalEstoque },
       {nameof(prdoutosMaisCarosTop3), prdoutosMaisCarosTop3 }
    };

ExibirDicionario(lista4);