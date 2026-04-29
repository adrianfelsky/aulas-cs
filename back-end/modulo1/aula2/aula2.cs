//Exercício 1
    Console.WriteLine("Qual seu nome?");
    string nome = Console.ReadLine();
    Console.WriteLine("Qual sua idade?");
    byte idade = byte.Parse(Console.ReadLine());

    Console.WriteLine($"{nome} - {idade}");

//Exercício 2

    Console.WriteLine("Informe dois números inteiros:");
    int numero1 = int.Parse(Console.ReadLine());
    int numero2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"Soma : {numero1 + numero2}");
    Console.WriteLine($"Subtração: {numero1 - numero2}");
    Console.WriteLine($"Multiplicação: {numero1 * numero2}");
    Console.WriteLine($"Divisão: {(float)numero1 / (float)numero2}");

//Exercício 3

Console.Write("Qual seu salário? (utilize ponto ',' para separação de centavos): ");
decimal salarioTemp = decimal.Parse(Console.ReadLine());
string salario = salarioTemp.ToString("c2");

decimal anualTemp = salarioTemp * 12;
string anual = anualTemp.ToString("c2");

Console.WriteLine($"Seu salário de {salario} é {anual} anualmente.");

