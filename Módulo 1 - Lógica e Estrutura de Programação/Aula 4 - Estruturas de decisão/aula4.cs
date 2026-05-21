Dictionary<string, string> users = new Dictionary<string, string>
{
    {"adrian", "123" },
    {"jose", "456" },
    {"everson", "789" },
};

bool saida = false;
bool cadastro = false;

string senha = "";
string login = "";

while (!saida)
{
    Console.Write("Login: ");
    login = Console.ReadLine();


    if (!users.ContainsKey(login))
    {
        Console.WriteLine("Usuario não cadastrado.");
        Console.Write("Deseja criar um usuário? (s/n): ");

        if (Console.ReadLine() != "s") saida = true;
        else
        {
            Console.Write("Qual será seu login? ");
            login = Console.ReadLine();

            Console.Write("E sua senha? ");
            senha = Console.ReadLine();

            users.Add(login, senha);

            Console.WriteLine("Usuário cadastrado.");
            cadastro = true;

        }
    }
    else cadastro = false;

    if (!cadastro)
    {
        for (int i = 0; i <= 2; i++)
        {
            if (!saida)
            {
                Console.Write("Senha: ");
                senha = Console.ReadLine();

                if (senha == users[login])
                {
                    Console.WriteLine("Acesso liberado.");
                    i = 2;
                    saida = true;
                }
                else
                {
                    if (i >= 2)
                    {
                        Console.WriteLine("Tentativas demais. Acesso negado.");
                        saida = true;
                    }
                    else
                    {
                        Console.Write($"Acesso negado.\nTentativas restantes: {2 - i}\nTentar novamente? (s/n): ");

                        if (Console.ReadLine() != "s")
                        {
                            Console.Write("Redefinir senha? (s/n): ");
                            if (Console.ReadLine() != "s") saida = true;
                            else
                            {
                                Console.Write("Qual sua nova senha? ");
                                users[login] = Console.ReadLine();
                                i = 2;

                            }
                        }

                    }
                }
            }
        }
    }
}

Console.WriteLine("Programa Encerrado.");
