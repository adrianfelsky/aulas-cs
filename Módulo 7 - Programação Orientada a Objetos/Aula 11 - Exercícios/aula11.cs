using aula11;

void exercicio(int num)
{
    Console.WriteLine($"\n#########\nExercício {num}\n#########\n");
}
/*
exercicio(1);

Produto[] produtos = {
    new Produto { Nome = "Notebook", Preco = 2500.00 },
    new Produto { Nome = "Smartphone", Preco = 1500.00 },
    new Produto { Nome = "Tablet", Preco = 1200.00 }
};

for (int i=0;i<produtos.Length;i++)
{
    produtos[i].ExibirInformacoes();
}

exercicio(2);

Pessoa.CadastroPessoa();

exercicio(3);

Aluno[] alunosEx3 = {
    new Aluno { Nome = "Alice", Idade = 20, Nota = 8.5f },
    new Aluno { Nome = "Bob", Idade = 22, Nota = 6.0f },
    new Aluno { Nome = "Charlie", Idade = 19, Nota = 7.0f }
};

for (int i = 0; i < alunosEx3.Length; i++)
{
    alunosEx3[i].VerificarSituacao();
}
*/
exercicio(4);

ContaBancaria conta1 = new ContaBancaria()
{
    Titular = "12345-6",
    Saldo = 1000.00,
};

Console.WriteLine("===== CONTA BANCÁRIA =====");
bool sair =false;
while (!sair)
{
    switch (ContaBancaria.Menu())
    {
        case "1": conta1.Sacar(); break;
        case "2": conta1.Depositar(); break;
        case "3": conta1.ExibirSaldo(); break;
        case "x": conta1.Sair(); sair = true; break;

        default:
            Console.WriteLine("Operação inválida. Por favor, escolha uma opção válida.");
            break;

    }
} 
/*
exercicio(5);

Produto[] produtosEx5 = new Produto[3];
for (int i = 0; i < produtosEx5.Length; i++)
{
    Console.Write($"\nDigite o nome do produto {i + 1}:\n >> ");
    string nomeProduto = Console.ReadLine();
    Console.Write($"Digite o preço do produto {i + 1}:\n >> ");
    double precoProduto;
    while (!double.TryParse(Console.ReadLine(), out precoProduto))
    {
        Console.Write("Preço inválido. Digite um número válido:\n >> ");
    }
    produtosEx5[i] = new Produto { Nome = nomeProduto, Preco = precoProduto };
}

for (int i = 0; i < produtosEx5.Length; i++)
{
    produtosEx5[i].ExibirInformacoes();
}

exercicio(6);

string nomeProcurado ="";

Pessoa[] pessoasEx6 = {
    new Pessoa { Nome = "Alice", Idade = 30 },
    new Pessoa { Nome = "Bob", Idade = 25 },
    new Pessoa { Nome = "Charlie", Idade = 35 }
};
while (nomeProcurado != "0")
{
    Console.Write("Digite um usuário para pesquisar na base.\n >> ");
    nomeProcurado = Console.ReadLine();

    for (int i = 0; i < pessoasEx6.Length; i++)
    {
        if (nomeProcurado == "0")
        {
            Console.WriteLine("Encerrando a pesquisa...");
            break;
        }
        if (pessoasEx6[i].Nome == nomeProcurado)
        {
            Console.WriteLine($"\nUsuário encontrado: {pessoasEx6[i].Nome}, Idade: {pessoasEx6[i].Idade}");
            break;
        }
        if (i == pessoasEx6.Length - 1)
        {
            Console.WriteLine("\nUsuário não encontrado.");
        }
    }
}

exercicio(7);

Produto[] produtosEx7 = {
    new Produto { Nome = "Notebook", Preco = 2500.00 },
    new Produto { Nome = "Smartphone", Preco = 1500.00 },
    new Produto { Nome = "Tablet", Preco = 1200.00 }
};

Produto maisCaro = new Produto { Nome = "", Preco = 0.0 };

for (int i = 0; i < produtosEx7.Length; i++)
{
    if (produtosEx7[i].Preco > maisCaro.Preco)
    {
        maisCaro = produtosEx7[i];
    }
}

Console.WriteLine($"Produto mais caro:");
maisCaro.ExibirInformacoes();


exercicio(8);


Aluno[] alunosEx8 = new Aluno[3];

for (int i = 0; i < alunosEx8.Length; i++)
{
    Console.Write($"\nDigite o nome do aluno {i + 1}:\n >> ");
    string nomeAluno = Console.ReadLine();
    alunosEx8[i] = new Aluno { Nome = nomeAluno};
}

Console.WriteLine("Alunos Cadastrados");
for (int i = 0; i < alunosEx8.Length; i++)
{
    Console.WriteLine( i+1 + ". " + alunosEx8[i].Nome);
}

exercicio(9);

string opcaoEx9 = "";

bool ContaExiste(string user)
{
    if (user == "")
    {
        Console.WriteLine("\nNenhuma conta criada. Por favor, crie uma conta primeiro.");
        return false;
    }
    else return true;
    
}
ContaBancaria novaConta = new ContaBancaria { Titular = "", Saldo = 0.0 };

Console.WriteLine($"{ new string('=', 25)}\n" +
    $"{new string('=', 5)} CONTA BANCÁRIA {new string('=', 4)}\n" +
    $"{new string('=', 25)}");

while (opcaoEx9 != "5")
{

    Console.Write("""

        1 - Criar Conta
        2 - Depositar
        3 - Sacar
        4 - Ver Saldo
        5 - Encerrar

         >> 
        """);

    opcaoEx9 = Console.ReadLine();

    switch (opcaoEx9)
    {
        case "1":
            if (novaConta.Titular != "")
            {
                Console.WriteLine("\nJá existe uma conta criada. Por favor, escolha outra opção.");
                break;
            }
            Console.Write("\nDigite o nome do titular da conta:\n >> ");
            string titular = Console.ReadLine();
            novaConta.Titular = titular;
            Console.WriteLine($"\nConta criada para {novaConta.Titular} com saldo inicial de R${novaConta.Saldo}");
            break;
        case "2":
            if (!ContaExiste(novaConta.Titular)) break;
            Console.Write("\nDigite o valor a ser depositado:\n >> ");
            if (double.TryParse(Console.ReadLine(), out double valorDeposito))
            {
                novaConta.Depositar(valorDeposito);
            }
            else
            {
                Console.WriteLine("Valor inválido. Por favor, digite um número válido.");
            }
            break;
        case "3":
            if (!ContaExiste(novaConta.Titular)) break;
            Console.Write("\nDigite o valor a ser sacado:\n >> ");
            if (double.TryParse(Console.ReadLine(), out double valorSaque))
            {
                novaConta.Sacar(valorSaque);
            }
            else
            {
                Console.WriteLine("Valor inválido. Por favor, digite um número válido.");
            }
            break;
        case "4":
            if (!ContaExiste(novaConta.Titular)) break;
            novaConta.ExibirSaldo();
            break;
        case "5":
            Console.WriteLine("Encerrando o programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }
}

exercicio(10);

string opcaoEx10 = "";

int tam = 5;
int k = 0;

Pessoa[] novasPessoas = new Pessoa[tam];

Console.WriteLine($"{new string('=', 25)}\n" +
    $"{new string('=', 3)} CADASTRO PESSOAS {new string('=', 3)}\n" +
    $"{new string('=', 25)}");


while (opcaoEx10 != "4")
{

    Console.Write("""

        1 - Cadatrar Usuário
        2 - Listar Usuários
        3 - Buscar Usuário
        4 - Encerrar

         >> 
        """);

    opcaoEx10 = Console.ReadLine();

    switch (opcaoEx10)
    {
        case "1":
            if (k >= tam)
            {
                Console.WriteLine("\nNúmero máximo de usuários atingido. Por favor, escolha outra opção.");
                break;
            }
            Console.Write("\nDigite o nome do usuário:\n >> ");

            novasPessoas[k] = new Pessoa { Nome = Console.ReadLine() };
            Console.WriteLine($"Usuário {novasPessoas[k].Nome} cadastrado.");
            k++;
            break;
        case "2":

            for (int i = 0; i < novasPessoas.Length; i++)
            {
                if (novasPessoas[i] != null)
                {
                    Console.WriteLine($"{i + 1}. {novasPessoas[i].Nome}");
                }
                else if (i == novasPessoas.Length - 1)
                {
                    Console.WriteLine("\nNenhum usuário cadastrado.");
                }
            }
            break;
        case "3":
            if (novasPessoas[0] != null)
            {
                Console.Write("Digite o nome do usuário a ser buscado.\n >> ");
                string nomeBuscado = Console.ReadLine();

                for (int i = 0; i < k; i++)
                {

                    if (novasPessoas[i].Nome == nomeBuscado)
                    {
                        Console.WriteLine($"\nUsuário encontrado: {novasPessoas[i].Nome}");
                        break;
                    }
                    else if (i == k - 1)
                    {
                        Console.WriteLine("\nUsuário não encontrado.");
                    }
                }
            } else Console.WriteLine("Nenhum usuário cadastrado.");

    break;
        case "4":
            Console.WriteLine("Encerrando o programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }
}

Console.WriteLine($"\n#########\nDesafio\n#########\n");



string opcaoDesafio = "";

int tamDesafio = 5;
int count = 0;

Aluno[] alunos = new Aluno[tamDesafio];

Console.WriteLine($"{new string('=', 25)}\n" +
    $"{new string('=', 5)} NOTAS {new string('=', 5)}\n" +
    $"{new string('=', 25)}");

float somaNotas = 0;

while (opcaoDesafio != "5")
{

    Console.Write("""

        1 - Cadatrar aluno
        2 - Listar alunos
        3 - Mostar média da turma
        4 - Mostrar aprovados
        5 - Encerrar

         >> 
        """);

    opcaoDesafio = Console.ReadLine();

    switch (opcaoDesafio)
    {
        case "1":
            if (count >= tamDesafio)
            {
                Console.WriteLine("\nNúmero máximo de alunos atingido. Por favor, escolha outra opção.");
                break;
            }
            Console.Write("\nDigite o nome do aluno:\n >> ");
            alunos[count] = new Aluno { Nome = Console.ReadLine() };
            Console.Write("Digite a nota do aluno:\n >> ");

            while (!float.TryParse(Console.ReadLine(), out alunos[count].Nota))
            {
                Console.Write("Nota inválida. Por favor, digite um número válido:\n >> ");
            }
            somaNotas += alunos[count].Nota;

            Console.WriteLine($"Usuário {alunos[count].Nome} cadastrado.");
            count++;
            break;
        case "2":

            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] != null)
                {
                    Console.WriteLine($"{i + 1}. {alunos[i].Nome} - {alunos[i].Nota}");
                }
                else if (i == alunos.Length - 1)
                {
                    Console.WriteLine("\nNenhum usuário cadastrado.");
                }
            }
            break;
        case "3":
            Aluno.MediaTurma(somaNotas,count);

            break;

        case "4":
            int alunosAprovados=0;
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] != null)
                {
                    if (alunos[i].VerificarSituacao()) alunosAprovados++;
                }
                else if (i == alunos.Length - 1)
                {
                    Console.WriteLine("\nNenhum usuário cadastrado.");
                }
            }

            Console.WriteLine($"Alunos aprovados: {alunosAprovados}");

            break;
        case "5":
            Console.WriteLine("Encerrando o programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }
}

*/