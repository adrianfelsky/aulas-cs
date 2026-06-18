/*// exercicio1
static async Task SaudarAsync(string nome)
{
    Console.WriteLine($"Olá, {nome}! Esse é o async/wait.");
    await Task.Delay(1000);
}

await SaudarAsync("Mundo");
await SaudarAsync("Marte");
await SaudarAsync("Júpiter");

//exercicio2
static async Task<double> CalcularMediaAsync(List<int> numeros)
{
    Console.WriteLine("Processando...");
    await Task.Delay(2500);
    double media = numeros.Average();
    return media;
}

List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

double media = await CalcularMediaAsync(numeros);
Console.WriteLine($"Média dos números: {media}");

//exercicio3
static async Task<int> DividirAsync(int a, int b)
{
    if (b == 0)
    {
        throw new DivideByZeroException("Divisão por zero não é permitida.");
    }
    Console.WriteLine("Dividindo...");
    await Task.Delay(2500);
    return a / b;
}

try
{
    int resultado = await DividirAsync(10, 2);
    Console.WriteLine($"Resultado da divisão: {resultado}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
finally
{
    Console.WriteLine("Operação concluída.");
}

//exericico4

using System.Diagnostics;

static async Task<string> SimularDownloadAsync(string arquivo)
{
    Console.WriteLine($"Iniciando download de {arquivo}...");
    await Task.Delay(3000); // Simula o tempo de download
    return $"Arquivo {arquivo} baixado";
}
var start = Stopwatch.StartNew();
List<string> arquivos = new List<string> { "relatorio.pdf", "foto.jpg", "dados.csv", "config.json" };

var tarefa1 = SimularDownloadAsync(arquivos[0]);
var tarefa2 = SimularDownloadAsync(arquivos[1]);
var tarefa3 = SimularDownloadAsync(arquivos[2]);
var tarefa4 = SimularDownloadAsync(arquivos[3]);

string[] resultados = await Task.WhenAll(tarefa1, tarefa2, tarefa3, tarefa4);

start.Stop();

Console.WriteLine($"tempo total {start}");

//exercicio5

Console.WriteLine("Iniciando busca de posts na API...");

// Buscando os posts 1, 2 e 3 em sequência (um await por vez), conforme o enunciado
await BuscarPostAsync(1);
await BuscarPostAsync(2);
await BuscarPostAsync(3);

Console.WriteLine("\nBusca finalizada com sucesso!");


// Método com a assinatura exata pedida no exercício
static async Task BuscarPostAsync(int id)
{
    // O 'using' garante que o HttpClient será descartado da memória após o uso
    using HttpClient client = new HttpClient();
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

    try
    {
        // Faz a requisição GET para /posts/{id}
        string jsonRetornado = await client.GetStringAsync($"posts/{id}");

        // Exibe o JSON retornado no console
        Console.WriteLine($"\n--- JSON do Post {id} ---");
        Console.WriteLine(jsonRetornado);
    }
    catch (HttpRequestException ex)
    {
        // Trata problemas de rede (ex: internet caiu, API fora do ar) com uma mensagem clara
        Console.WriteLine($"\n[ERRO DE CONEXÃO] Não foi possível buscar o post {id}.");
        Console.WriteLine($"Detalhes: {ex.Message}");
    }
}
*/

using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

// 1. Modelos para extrair apenas o Título do Post e o Nome do Usuário
class Post { public string title { get; set; } }
class Usuario { public string name { get; set; } }

// 2. Setup do HttpClient (Reaproveitar a mesma instância é a melhor prática para múltiplas requisições)
using var client = new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com/") };

Console.WriteLine("Iniciando requisições em paralelo...");

// Stopwatch serve para medir o tempo exato de execução
var cronometro = Stopwatch.StartNew();

// 3. Disparamos as requisições, mas NÃO colocamos o 'await' aqui. 
// Isso cria a Task (a promessa de que o dado vai chegar), mas não trava o programa.
var taskPost1 = BuscarPostAsync(1);
var taskPost2 = BuscarPostAsync(2);
var taskPost3 = BuscarPostAsync(3);

var taskUser1 = BuscarUsuarioAsync(1);
var taskUser2 = BuscarUsuarioAsync(2);
var taskUser3 = BuscarUsuarioAsync(3);

// 4. Aqui a mágica acontece: Aguardamos TODAS as tarefas terminarem juntas
await Task.WhenAll(taskPost1, taskPost2, taskPost3, taskUser1, taskUser2, taskUser3);

// Paramos o cronômetro assim que a última requisição do lote for concluída
cronometro.Stop();

// 5. Exibição do Mini-Dashboard
Console.WriteLine("\n=== MINI-DASHBOARD ===");

Console.WriteLine("\nPOSTS:");
// Acessamos o .Result de cada Task, pois sabemos que a esta altura elas já terminaram
ExibirPost(taskPost1.Result, 1);
ExibirPost(taskPost2.Result, 2);
ExibirPost(taskPost3.Result, 3);

Console.WriteLine("\nUSUÁRIOS:");
ExibirUsuario(taskUser1.Result, 1);
ExibirUsuario(taskUser2.Result, 2);
ExibirUsuario(taskUser3.Result, 3);

Console.WriteLine($"\n[Tempo total das 6 requisições paralelas: {cronometro.ElapsedMilliseconds} ms]");


// --- FUNÇÕES LOCAIS ---

async Task<Post> BuscarPostAsync(int id)
{
    try
    {
        string json = await client.GetStringAsync($"posts/{id}");
        return JsonConvert.DeserializeObject<Post>(json);
    }
    catch (HttpRequestException ex)
    {
        // Tratamos o erro internamente para não derrubar o Task.WhenAll
        Console.WriteLine($"[ERRO] Falha isolada ao carregar o Post {id}: {ex.Message}");
        return null;
    }
}

async Task<Usuario> BuscarUsuarioAsync(int id)
{
    try
    {
        string json = await client.GetStringAsync($"users/{id}");
        return JsonConvert.DeserializeObject<Usuario>(json);
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"[ERRO] Falha isolada ao carregar o Usuário {id}: {ex.Message}");
        return null;
    }
}

void ExibirPost(Post p, int id)
{
    if (p != null) Console.WriteLine($"- Post #{id}: {p.title}");
}

void ExibirUsuario(Usuario u, int id)
{
    if (u != null) Console.WriteLine($"- Usuário #{id}: {u.name}");
}
