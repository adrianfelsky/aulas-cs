using System;

string opcao = "";
float num1;
string[] historico = new string[10];
int incremento = 0;
bool validator = true; // não incrementa se a operação for h ou invalida

Console.WriteLine("== CALCULADORA ==");

Console.Write("Digite o número inicial:\n>> ");
float num = float.Parse(Console.ReadLine());

do
{
    Console.Write("""
        
        Digite uma operação:
        + : Soma
        - : Subtração
        * : Multiplicação
        / : Divisão
        h : Histórico de operações
        x : Sair

        >> 
        """);
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "+":
            Console.Write("Digite o número:\n>> ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine($"  Operação (soma):");
            historico[incremento] = $"{num} + {num1} = {num + num1}";
            Console.WriteLine(historico[incremento]);
            num += num1;
            break;

        case "-":
            Console.Write("Digite o número:\n>> ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine($"  Operação (subtração):");
            historico[incremento] = $"{num} - {num1} = {num - num1}";
            Console.WriteLine(historico[incremento]);
            num -= num1;
            break;

        case "*":
            Console.Write("Digite o número:\n>> ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine($"  Operação (multiplicação):");
            historico[incremento] = $"{num} * {num1} = {num * num1}";
            Console.WriteLine(historico[incremento]);
            num *= num1;
            break;

        case "/":

            do
            {
                Console.Write("Digite o número:\n>> ");
                num1 = float.Parse(Console.ReadLine());
                if (num1 == 0) Console.WriteLine("Divisão por zero não é permitida.\nDigite outro número.");
            } while (num1 == 0);

            Console.WriteLine($"  Operação (divisão):");
            historico[incremento] = $"{num} / {num1} = {num / num1}";
            Console.WriteLine(historico[incremento]);
            num /= num1;
            break;

        case "h":
        case "x":
            
            if (opcao=="x") Console.WriteLine("Encerrando a calculadora...");
            
            Console.WriteLine("Histórico de operações:");

            for (int i = 0; i < historico.Length; i++)
            {
                if (historico[i] != null) Console.WriteLine(historico[i]);
                else if(i == historico.Length-1 && historico[0]==null) Console.WriteLine("Nenhuma operação registrada.");
            }

            validator = false;
            break;

        default:
            Console.WriteLine("Operação inválida. Informe uma operação válida.");
            validator = false;
            break;

    }

    if(validator) incremento++;
    validator = true;
    if (incremento >= historico.Length) incremento = 0;
} while (opcao != "x");

