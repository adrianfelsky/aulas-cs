/*//Aula

string[] nomes = [
    "João",
    "Maria",
    "Pedro",
    "Ana",
    "Carlos"
];

for (int i = 0; i < nomes.Length; i++)
{
    Console.Write(nomes[i]);
    if (i == nomes.Length - 1) Console.WriteLine(".");
    else Console.Write(", ");
}

Console.WriteLine();

Console.WriteLine("Select = \n   " + string.Join(", ", nomes.Select(x => x))+".");
Console.WriteLine("Aggregate = \n   " + nomes.Aggregate((a, b) => a + ", " + b)+".");
Console.WriteLine("All(Pedro) = \n   " + nomes.All(x => x == "Pedro"));
Console.WriteLine("Any(Pedro) = \n   " + nomes.Any(x => x == "Pedro"));
Console.WriteLine("Contains(Pedro) = \n   " + nomes.Contains("Pedro"));
Console.WriteLine("Count(Pedro) = \n   " + nomes.Count(x => x == "Pedro"));
Console.WriteLine("Count = \n   " + nomes.Count());
Console.WriteLine("First = \n   " + nomes.First());
Console.WriteLine("Last = \n   " + nomes.Last());
Console.WriteLine("Skip(2) = \n   " + string.Join(", ", nomes.Skip(2)));
Console.WriteLine("Take(2) = \n   " + string.Join(", ", nomes.Take(2)));
Console.WriteLine("OrderBy = \n   " + string.Join(", ", nomes.OrderBy(x => x)));
Console.WriteLine("OrderByDescending = \n   " + string.Join(", ", nomes.OrderByDescending(x => x)));
Console.WriteLine("Reverse = \n   " + string.Join(", ", nomes.Reverse()));
Console.WriteLine("Concat = \n   " + string.Join(", ", nomes.Concat(new string[] { "Lucas", "Mariana" })));
Console.WriteLine("Union = \n   " + string.Join(", ", nomes.Union(new string[] { "Lucas", "Mariana" })));
Console.WriteLine("Except(Lucas, Mariana) = \n   " + string.Join(", ", nomes.Except(new string[] { "Lucas", "Mariana" })));
Console.Write("Append: \n   ");
string[] addName = nomes.Append("Lucas").ToArray();
addName = nomes.Append("Mariana").ToArray();

for (int i = 0; i < addName.Length; i++)
{
    Console.Write(addName[i]);
    if (i == addName.Length - 1) Console.WriteLine(".");
    else Console.Write(", ");
}
*/

//Exercicio1
Console.WriteLine("\nExercício 1:\n");

int[] nums = [4,5,8,1,6];

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}




//Exercicio2
Console.WriteLine("\nExercício 2:\n");

string[] names = new string[5];
Console.WriteLine($"Escreva {names.Length} nomes:");

for (int i = 0; i < names.Length; i++)
{
    names[i] = Console.ReadLine();
}

Console.WriteLine("\nNomes:");
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}




//Exercicio3
Console.WriteLine("\nExercício 3:\n");

int[] numeros = new int[5];
Console.WriteLine("Escreva 5 números (soma):");

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.Write("\nSoma:" + numeros.Sum());




//Exercicio4
Console.WriteLine("\nExercício 4:\n");

int[] newNumeros = new int[5];
int maior =0;
Console.WriteLine("Escreva 5 números (maior):");

for (int i = 0; i < 5; i++)
{
    newNumeros[i] = int.Parse(Console.ReadLine());
}

Console.Write("\nMaior [.Max()]:" + newNumeros.Max());

for (int i = 0; i < newNumeros.Length; i++)
{
    if (i == 0) maior = newNumeros[i];
    else if (newNumeros[i] > newNumeros[i - 1]) maior = newNumeros[i];
}
Console.WriteLine("\nMaior (Comparação):"+maior);





//Exercicio5
Console.WriteLine("\nExercício 5:\n");

int[] newNumeros2 = new int[5];
Console.WriteLine("Escreva 5 números (maior que 10):");

for (int i = 0; i < newNumeros2.Length; i++)
{
    newNumeros2[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Maiores que 10:");
for (int i = 0; i < newNumeros2.Length; i++)
{
    if (newNumeros2[i] >10) Console.WriteLine(newNumeros2[i]);
}




//Desafio
Console.WriteLine("\nDesafio:\n");

float[] notas = new float[6];
float media=0;
Console.WriteLine("Escreva as 6 notas do aluno:");

for (int i = 0; i < notas.Length; i++)
{
    notas[i] = float.Parse(Console.ReadLine());
}

Console.WriteLine("Média [.Average()]:" + notas.Average());
media = notas.Sum()/notas.Length;
Console.WriteLine("\nMédia (Comparação):" + media);
