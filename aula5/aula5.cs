//exercicio1
int i = 0;
Console.WriteLine("\nExercício 1:");
Console.Write($"    ");
while (i <= 10)
{
    Console.Write($"{i} ");
    i++;
}
Console.Write("\n");

//exercicio2
Console.WriteLine("\nExercício 2:");
Console.Write($"    ");
for (i = 0; i <= 10; i++)
{
    if (i % 2 == 0)
        Console.Write($"{i} ");
}
Console.Write("\n");

//exercicio3
Console.WriteLine("\nExercício 3:");
do
{
    Console.Write("    Escreva um número (maior que 0): ");
    i = int.Parse(Console.ReadLine());
} while (i <= 0);

//exercicio4
Console.WriteLine("\nExercício 4:");

string senha = "1234";
string senhaDigitada = "";
do
{
    Console.Write("    Escreva a senha: ");
    senhaDigitada = Console.ReadLine();
    if (senhaDigitada != senha) Console.WriteLine("      Tente novamente!");

} while (senha != senhaDigitada);

Console.WriteLine("      Acesso Liberado!");

//exercicio5
Console.WriteLine("\nExercício 5:");
for (int j = 1; j <= 3; ++j)
{
    Console.WriteLine($"    Número {j}:");
    do
    {
        Console.Write("      Escreva um número (maior que 0): ");
        i = int.Parse(Console.ReadLine());
        switch(i)
        {
            case (>10):
                Console.WriteLine("        Número Alto");
                break;
            case (< 0):
                Console.WriteLine("        Menor que 0");
                break;
            default:
                Console.WriteLine("        Número Baixo");
                break;
            }
        } while (i <= 0);
    Console.WriteLine($"     Número digitado: {i}");
}

Console.WriteLine("  Programa Finalizado.");
