//Exercício 1
Console.WriteLine("\nExercício 1");

int numExer1;

do
{
    Console.Write("Informe um número de 1 a 3: ");
    numExer1 = int.Parse(Console.ReadLine());
    if (numExer1 > 3 || numExer1 < 1) Console.WriteLine("Opção inválida.");
} while (numExer1 > 3 || numExer1 < 1);

switch (numExer1)
{
    case 1:
        Console.WriteLine("Bom dia!");
        break;
    case 2:
        Console.WriteLine("Boa tarde.");
        break;
    case 3:
        Console.WriteLine("Boa noite.");
        break;
}


//Exercício 2
Console.WriteLine("\nExercício 2");

Console.WriteLine("Informe 5 números:");
int[] numerosExer2 = new int[5];

for (int i = 0; i < numerosExer2.Length; i++)
{
    numerosExer2[i] = int.Parse(Console.ReadLine());
}

float mediaExer2 = (float)(numerosExer2.Sum() / numerosExer2.Length);
//float media = numerosExer2.Average();

Console.Write("Números maiores que a media: ");

for (int i = 0; i < numerosExer2.Length; i++)
{
    if (numerosExer2[i] > mediaExer2)
    {
        Console.Write(numerosExer2[i] + " ");
    }
}


//Exercício 3
Console.WriteLine("\nExercício 3");

Console.WriteLine("Informe 5 números:");
int[] numbersExer3 = new int[5];

for (int i = 0; i < numbersExer3.Length; i++)
{
    numbersExer3[i] = int.Parse(Console.ReadLine());
}

int mult = 1;

for (int i = 0; i < numbersExer3.Length; i++)
{
    mult *= numbersExer3[i];
}

Console.WriteLine("Multiplicação dos números: " + mult);


//Exercício 4
Console.WriteLine("\nExercício 4");

Console.WriteLine("Informe 5 números:");
int[] array1 = new int[5];
int[] array2 = new int[5];

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < array1.Length; i++)
{
    array2[i] = array1[i] * 2;

}
Console.WriteLine("Array 1: ");
for (int i = 0; i < array1.Length; i++)
{
    Console.Write(array1[i] + " ");
}
Console.WriteLine("\nArray 2: ");
for (int i = 0; i < array2.Length; i++)
{
    Console.Write(array2[i] + " ");
}

//Exercício 5
Console.WriteLine("\nExercício 5");

Console.WriteLine("Informe 6 números:");
int[] numsExer5 = new int[6];

for (int i = 0; i < numsExer5.Length; i++)
{
    numsExer5[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Números pares:");
for (int i = 0; i < numsExer5.Length; i++)
{
    if (numsExer5[i] % 2 == 0)
    {
        Console.Write(numsExer5[i] + " ");
    }

}

//Exercício 6
Console.WriteLine("\nExercício 6");

string[] nomesExer6 = { "Maria", "João", "Ana", "Carlos", "Beatriz" };
Console.Write("Insira um nome: ");

string nomeExerc6 = Console.ReadLine();


//if (nomesExer6.Contains(nomeExerc6))
//{
//    Console.WriteLine("Encontrado.");
//}
//else
//{
//    Console.WriteLine("Não encontrado.");
//}

for (int i = 0; i < nomesExer6.Length; i++)
{
    bool encontrado = false;
    if (nomesExer6[i] == nomeExerc6)
    {
        Console.WriteLine("Encontrado.");
        encontrado = true;
    }
    else if (i == nomesExer6.Length - 1 && !encontrado)
    {
        Console.WriteLine("Não encontrado.");
    }
}



//Exercício 7
Console.WriteLine("\nExercício 7");

Console.WriteLine("Informe 5 números:");
int[] numsExer7 = new int[5];

for (int i = 0; i < numsExer7.Length; i++)
{
    numsExer7[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Números na ordem inversa:");
for (int i = numsExer7.Length - 1; i >= 0; i--)
{
    Console.WriteLine(numsExer7[i]);

}


//Exercício 8
Console.WriteLine("\nExercício 8");

Console.WriteLine("Informe 5 números:");
int[] numsExer8 = new int[5];



for (int i = 0; i < numsExer8.Length; i++)
{
    do
    {
        numsExer8[i] = int.Parse(Console.ReadLine());
        if (numsExer8[i] < 0)
        {
            Console.WriteLine("Número inválido (<0).");
        }
    } while (numsExer8[i] < 0);
}

//Console.WriteLine($"Números válidos: {string.Join(", ", numsExer8)}");

Console.WriteLine("Números válidos:");
for (int i = 0; i < numsExer8.Length; i++)
{
    Console.WriteLine(numsExer8[i] + " ");
}


//Exercício 9
Console.WriteLine("\nExercício 9");

Console.WriteLine("Informe 5 números:");
int[] numsExer9 = new int[5];

for (int i = 0; i < numsExer9.Length; i++)
{
    numsExer9[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numsExer9.Length; i++)
{
    //Console.WriteLine($"Loop {i+1}:");
    for (int j = 0; j < numsExer9.Length - 1; j++)
    {
        if (numsExer9[j] > numsExer9[j + 1])
        {
            int temp = numsExer9[j];
            numsExer9[j] = numsExer9[j + 1];
            numsExer9[j + 1] = temp;
        }

        //Console.WriteLine($"Troca {j+1}:");

        //for (int k = 0; k <= numsExer9.Length - 1; k++)
        //{
        //    Console.Write(numsExer9[k] + " ");
        //}

        //Console.WriteLine();
    }
}

Console.WriteLine("Números ordenados:");

for (int i = 0; i < numsExer9.Length; i++)
{
    Console.WriteLine(numsExer9[i]);
}


//Exercício 10
Console.WriteLine("\nExercício10");

Console.WriteLine("Informe 10 números:");
int[] numsExer10 = new int[10];

for (int i = 0; i < numsExer10.Length; i++)
{
    numsExer10[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Pares:");
for (int i = 0; i < numsExer10.Length; i++)
{
    if (numsExer10[i] % 2 == 0)
    {
        Console.Write(numsExer10[i] + " ");
    }
}

Console.WriteLine("\nÍmpares");
for (int i = 0; i < numsExer10.Length; i++)
{
    if (numsExer10[i] % 2 != 0)
    {
        Console.Write(numsExer10[i] + " ");
    }
}

Console.WriteLine("\nMédia:");
Console.WriteLine((float)(numsExer10.Sum() / numsExer10.Length));

Console.Write("Maior valor: ");
int maiorExerc10 = numsExer10[0];

for (int i = 0; i < numsExer10.Length; i++)
{
    if (numsExer10[i] > maiorExerc10)
    {
        maiorExerc10 = numsExer10[i];
    }
}

Console.WriteLine(maiorExerc10);

Console.Write("Menor valor: ");

int menorExerc10 = numsExer10[0];

for (int i = 0; i < numsExer10.Length; i++)
{
    if (numsExer10[i] < maiorExerc10)
    {
        menorExerc10 = numsExer10[i];
    }
}

Console.WriteLine(menorExerc10);

//Desafio
Console.WriteLine("\nDesafio:");

string[] nomesDesafio = new string[5];
int opcao;
do
{
    Console.WriteLine("""
        Infome a opcão desejada:
            1 - Adicionar nome
            2 - Listar nomes
            3 - Buscar nome
            4 - Sair
        """);
    opcao = int.Parse(Console.ReadLine());
    switch(opcao)
    {
        case 1:
            Console.Write("Informe um nome: ");
            for (int i=0; i < nomesDesafio.Length; i++)
            {
                if (nomesDesafio[i] == "")
                {
                    nomesDesafio[i] = Console.ReadLine();
                    break;
                }
            }

            break;

        case 2:
            Console.WriteLine("Nomes cadastrados:");
            for (int i = 0; i < nomesDesafio.Length; i++)
            {
                Console.WriteLine(nomesDesafio[i]);
            }
            break;

        case 3:
            Console.Write("Informe o nome: ");
            string nomeBusca = Console.ReadLine();

            for (int i = 0; i < nomesDesafio.Length; i++)
            {
                if (nomesDesafio[i] == nomeBusca)
                {
                    Console.WriteLine("Nome encontrado.");
                    break;
                }
                else if (i == nomesDesafio.Length - 1)
                {
                    Console.WriteLine("Nome não encontrado.");
                }
            }
            break;

        case 4:

            Console.WriteLine("Saindo.");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
          
    }
} while (opcao != 4);
