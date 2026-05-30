using aula16;

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

var lista = new Dictionary<string, object>
    {
       {nameof(numeros), numeros },
       {nameof(maior10), maior10 },
       {nameof(par), par },
       {nameof(maior15), maior15}
    };

foreach (var (nome, valor) in lista)
{
    Console.WriteLine(nome+":");
    if (valor is IEnumerable<int> enumerableItems) 
    {
        foreach (var item in enumerableItems)
        {
            Console.WriteLine(item);
        }
    }
    else
    {
        Console.WriteLine(valor); 
    }
}

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

foreach (var (nome, valor) in lista2)
{
    Console.WriteLine(nome+":");
    if (valor is IEnumerable<string> enumerableItems)
    {
        foreach (var item in enumerableItems)
        {
            Console.Write(item +"  -  ");
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine(valor);
    }
    }

//exercicio5

var produtos = new List<Produto>
{
    new Produto("Notebook", 2500.00),
    new Produto("Smartphone", 1500.00),
    new Produto("Tablet", 800.00),
    new Produto("Monitor", 1200.00),
    new Produto("Teclado", 200.00),
    new Produto("Mouse", 100.00)
};

var produtosAcima1000 = produtos.Where(p => p.Preco > 300).ToList();
var produtosOrdenados = produtos.OrderBy(p => p.Preco).ToList();
var produtosNomes = produtos.Select(p => p.Nome).ToList();

var lista3 = new Dictionary<string, object>
    {
       {nameof(produtos), produtos },
       {nameof(produtosAcima1000), produtosAcima1000 },
       {nameof(produtosOrdenados), produtosOrdenados },
       {nameof(produtosNomes), produtosNomes}
    };

foreach (var (nome, valor) in lista3)
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


