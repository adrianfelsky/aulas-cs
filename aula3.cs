
//Idade
Console.Write("Qual sua data de nascimento?  ");
int nascimento = int.Parse(Console.ReadLine());
int idade = DateTime.Now.Year - nascimento;
Console.WriteLine("Você tem " + idade + " anos.");
bool permissao = true;

if (idade > 65)
{
    Console.WriteLine("Muito velho");
    permissao = false;
}
else if (idade > 18)
{
    Console.WriteLine("Adulto");
}
else
{
    Console.WriteLine("Muito novo");
    permissao = false;
}

if (permissao == true)
{
    Console.WriteLine("Você tem permissão para dirigir.");
}
else
{
    Console.WriteLine("Você não tem permissão para dirigir.");
}
