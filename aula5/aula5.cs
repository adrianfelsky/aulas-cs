//exercicio1
int i = 0;
Console.WriteLine("Exercício 1:");
while (i <= 10)
{
    Console.Write($"{i} ");
    i++;
}

//exercicio2
Console.WriteLine("\nExercício 2:");
for (i = 0; i <= 10; i++)
{
    if (i % 2 == 0)
        Console.Write($"{i} ");
}

//exercicio3
do
{
    Console.Write("\nEscreva um número: ");
    i = int.Parse(Console.ReadLine());
} while (i <= 0);
