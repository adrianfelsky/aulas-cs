int qtdCadastro = 5;
string[] nomes = new string[qtdCadastro];
string[] email = new string[qtdCadastro];
string[] cpf = new string[qtdCadastro];
string[] usuario = new string[qtdCadastro];
int opcao = 0;
int indice = 0;

Console.WriteLine("""
    
    
    ||||||||| BANCO DE DADOS CLIENTES |||||||||


    """);

while (opcao != 5)
{

    Console.WriteLine("""
        Escolha uma opção:

        1) Novo usuário
        2) Buscar usuário
        3) Excluir um usuário
        4) Listagem
        5) Sair

        """);



    Console.Write(" >> ");
    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Por favor, digite um número válido.");
        continue;
    }


    switch (opcao)
    {
        case 1:
            if (indice == qtdCadastro)
            {
                Console.WriteLine("Limite de usuários atingido!\n");
                continue;
            }
            Console.Write("Digite seu nome completo:\n >> ");
            nomes[indice] = Console.ReadLine();
            Console.Write("Informe seu e-mail:\n >> ");
            email[indice] = Console.ReadLine();
            Console.Write("Insira o número do seu CPF:\n >> ");
            cpf[indice] = Console.ReadLine();
            Console.Write("Defina o nome do seu usuário:\n >> ");
            usuario[indice] = Console.ReadLine();
            Console.WriteLine("Cadastro concluído com sucesso!");

            indice++;
            break;

        case 2:
        case 3:
            if (indice == 0)
            {
                Console.WriteLine("Nenhum usuário cadastrado no sistema.");
                break;
            }

            string operacaoNome = "";
            if (opcao == 2) operacaoNome = "Buscar";
            if (opcao == 3) operacaoNome = "Excluir";
            string operacao = "";
            bool menuValido = false;

            while (!menuValido)
            {
                Console.Write($"{operacaoNome} por nome(1), email(2), cpf(3) ou username(4)?\n >> ");
                operacao = Console.ReadLine();

                switch (operacao)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        menuValido = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            }

            Console.Write("Digite o termo que deseja procurar:\n >> ");
            string busca = Console.ReadLine();
            Console.WriteLine($"Procurando por {busca} ...");

            bool usuarioEncontrado = false;
            int indiceEncontrado = -1;

            for (int i = 0; i < indice; i++)
            {
                if (nomes[i] == "")
                {
                    continue;
                }

                switch (operacao)
                {
                    case "1" when nomes[i] == busca:
                    case "2" when email[i] == busca:
                    case "3" when cpf[i] == busca:
                    case "4" when usuario[i] == busca:
                        usuarioEncontrado = true;
                        indiceEncontrado = i;
                        break;
                }

                if (usuarioEncontrado) break;
            }

            if (usuarioEncontrado)
            {
                Console.WriteLine($"Usuário encontrado: {nomes[indiceEncontrado]}, {email[indiceEncontrado]}, {cpf[indiceEncontrado]}, {usuario[indiceEncontrado]}");

                if (opcao == 3)
                {
                    Console.Write("Deseja excluir este usuário? (s/n)\n >> ");
                    if (Console.ReadLine() == "s")
                    {
                        for (int j = indiceEncontrado; j < indice - 1; j++)
                        {
                            nomes[j] = nomes[j + 1];
                            email[j] = email[j + 1];
                            cpf[j] = cpf[j + 1];
                            usuario[j] = usuario[j + 1];
                        }

                        nomes[indice - 1] = null;
                        email[indice - 1] = null;
                        cpf[indice - 1] = null;
                        usuario[indice - 1] = null;

                        indice--;

                        Console.WriteLine("Usuário excluído com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Exclusão cancelada.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }
            break;



        case 4:

            Console.WriteLine("Usuários encontrados:");
            for (int i = 0; i < qtdCadastro; i++)
            {
                if(nomes[i]!=null) Console.WriteLine($"{nomes[i]}, {email[i]}, {cpf[i]}, {usuario[i]}");
                else if (i == qtdCadastro - 1 && nomes[0] == null) Console.WriteLine("Nenhum usuário registrado.");
            }
            break;
        case 5:
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Número inválido.");
            break;
    }
}