using aula12;

Console.WriteLine("\n###exercicio 1\n");//exercicio1

Produto p1 = new Produto();

Console.WriteLine(p1.Nome);

p1.Nome = "Coca-cola";

Console.WriteLine(p1.Nome);

Console.WriteLine("\n###exercicio 2\n");//exercicio2

Pessoa p2 = new Pessoa();

p2.Idade = 25;
Console.WriteLine(p2.Idade);
Pessoa p3 = new Pessoa();

Console.WriteLine(p3.Idade);

p3.Idade = -5;
Console.WriteLine(p3.Idade);

Console.WriteLine("\n###exercicio 3\n");//exercicio3

Conta conta = new Conta();

conta.Depositar(500);Console.WriteLine(conta.Saldo);

//conta.Saldo = 1000; //erro, pois o saldo é somente leitura

conta.Sacar(200); Console.WriteLine(conta.Saldo);
conta.Sacar(400); Console.WriteLine(conta.Saldo);

Console.WriteLine("\n###exercicio 4\n");//exercicio4

Aluno a = new Aluno();
Aluno b = new Aluno();

a.Nome = "João";
b.Nome = "Maria";

a.Nota = 8.5;
b.Nota = 4.0;

a.ExibirInfo();
b.ExibirInfo();

Console.Write("\nDigite qualquer tecla para continuar. ");Console.ReadLine();

//exercicio5

Carro carro = new Carro();

carro.Marca = "Toyota";
carro.Modelo = "Corolla";

string opcao = "";

while (opcao!="0")
{
    Console.Clear();
    Console.WriteLine("\n###exercicio 5\n");
    carro.ExibirInfo();

    Console.Write(""""

        1: Acelerar
        2: Frear
        0: Sair

        >> 
        """");

    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1": carro.Acelerar(5); break;
        case "2":carro.Frear(5); break;
        case "0": break;
        default: Console.WriteLine("Opção inválida."); break;
    }

}

User user =new User();

while (true)
{
    Console.Clear();
    Console.Write("\nInforme nome: ");
    user.Nome = Console.ReadLine();

    
    int idade;
    do
    {
        Console.Write("Informe idade: ");
        if (int.TryParse(Console.ReadLine(), out idade) && idade >= 0) user.Idade = idade;
        else
        {
            Console.WriteLine("Idade deve ser um número inteiro não negativo.");
            idade = -1; // força repetir o loop
        }
    } while (idade < 0);

    Console.Write("Informe email: ");
    user.Email = Console.ReadLine();

    Console.Write("\nDigite qualquer tecla para continuar. "); Console.ReadLine();
    if (user.Email!="") break;
}

user.ExibirInfo();
