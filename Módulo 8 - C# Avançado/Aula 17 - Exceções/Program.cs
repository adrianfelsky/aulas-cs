//exercicio1
using aula17;

while (true)
{
    Console.Write("Digite um número (ou 'x' para sair):");
    var input = Console.ReadLine();
    if (input == "x")
    {
        Console.WriteLine("saindo...");
        break;
    }
    try
    {
        int numero = int.Parse(input);
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: O valor digitado não é um número válido.");
    }
    catch (Exception ex)
    {

        Console.WriteLine($"Erro: {ex.Message}");
    }
}

//exercicio2
double SimularOperacao(double a, double b)
{
    if (b == 0)
    {
        throw new DivideByZeroException("Divisão por zero não é permitida.");
    }
    return a / b;
}

try
{
    Console.Write("Numero 1: ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("Numero 2: ");
    double b = double.Parse(Console.ReadLine());

    double resultado = SimularOperacao(a, b);
    Console.WriteLine($"Resultado: {resultado}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Operação finalizada.");
}
Console.WriteLine("");

Console.WriteLine("Digite qualquer tecla para continuar...");
Console.ReadLine();

//exercicio3
while (true)
{
    Console.Clear();
    Console.Write("Digite um número inteiro para 100 dividir por ele (ou 'x' para sair): ");
    var input = Console.ReadLine();
    try
    {
        if (input.ToLower() == "x")
        {
            Console.WriteLine("Saindo...");
            break;
        }
        int numero = int.Parse(input);
        Console.WriteLine($"100 / {numero} = {100 / numero}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: O valor digitado não é um número inteiro válido.");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Erro: Não é possível dividir por 0.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Erro: O número digitado é muito grande.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro inesperado: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Operação finalizada.\nDigite qualquer tecla para continuar...");
        Console.ReadLine();
    }
}

//exercicio4

while (true)
{
    Console.Clear();
    Console.Write("Digite o nome (ou 'x' para sair): ");
    var input1 = Console.ReadLine();
    if (input1.ToLower() == "x")
    {
        Console.WriteLine("Saindo...");
        break;
    }
    Console.Write("Digite a idade: ");
    var input2 = Console.ReadLine();
    try
    {
        int numero = int.Parse(input2);
        CadastrarPessoa(input1, numero);
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: A idade digitada não é um número inteiro válido.");
    }
    catch (IdadeInvalidaException ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro inesperado: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Operação finalizada.\nDigite qualquer tecla para continuar...");
        Console.ReadLine();
    }
}

void CadastrarPessoa(string nome, int idade)
{
    if (idade < 0 || idade > 150)
    {
        throw new IdadeInvalidaException();
    }
    Console.WriteLine($"Pessoa cadastrada: {nome}, {idade} anos.");
}

//exercicio5  
while (true)
{
    Console.Clear();
    Console.WriteLine("Calculadora");
    Console.Write("Informe o primeiro número (ou 'x' para sair): ");
    var input = Console.ReadLine();
    if (input == "x") 
    {
        Console.WriteLine("Saindo...");
        break;
    }

    try
    {
        if (!double.TryParse(input, out double num1))
            throw new FormatException();

        Console.Write("Informe o segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
            throw new FormatException();

        var calc = new Calculadora { Numero1 = num1, Numero2 = num2 };
        Console.Write("Informe a operação (+,-,*,/): ");
        var operacao = Console.ReadLine();

        double resultado = operacao switch  
        {
            "+" => calc.Somar(),
            "-" => calc.Subtrair(),
            "*" => calc.Multiplicar(),
            "/" => calc.Dividir(),
            _ => throw new InvalidOperationException("Operação inválida.")
        };

        Console.WriteLine($"Resultado: {resultado}");   
    }
    catch (FormatException)
    {
        Console.WriteLine("Valor digitado não é um número válido.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Operação finalizada.\nDigite qualquer tecla para continuar...");
        Console.ReadLine();
    }
}

//desafio

/// <summary>
/// Exceção personalizada do exercício 4 para indicar que a idade fornecida é inválida.
/// </summary>
class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException() :
        base("Idade inválida.")
    { }
}