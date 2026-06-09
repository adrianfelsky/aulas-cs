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

*/

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
