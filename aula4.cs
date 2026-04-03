//Login

Dictionary<string, string> users = new Dictionary<string, string>
{
    {"adrian", "123" },
    {"jose", "456" },
    {"everson", "789" },
};

byte numTentativas = 0;
bool tentativa = true;
bool redefine = false;
bool existe = false;
bool cadastro = true;
string senha ="";
string login="";

//##############################
//##############################
//##############################
//##############################
//##############################
//######### ALTERAÇÃO ##########
//##############################
//##############################
//##############################
//##############################
//##############################
//##############################


while (cadastro)
{
    Console.Write("Login: ");
    login = Console.ReadLine();


    if (!users.ContainsKey(login))
    {
        Console.WriteLine("Usuario não cadastrado.");
        Console.Write("Deseja criar um usuário? (s/n): ");
        if (Console.ReadLine() != "s")
        {
            tentativa = false;
            cadastro = false;

        }
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
}

while (tentativa)
{
    if (redefine == true)
    {
        Console.Write("Login: ");
        login = Console.ReadLine();
    }

    Console.Write("Senha: ");
    senha = Console.ReadLine();

    numTentativas++;

    if (senha == users[login])
    {
        Console.WriteLine("Acesso liberado.");
        tentativa = false;
    }
    else
    {
        if (numTentativas > 2)
        {
            Console.WriteLine("Tentativas demais. Acesso negado.");
            return;
        }

        Console.Write("Acesso negado.\nTentar novamente? (s/n): ");
        if (Console.ReadLine() != "s")
        {
            Console.Write("Redefinir senha? (s/n): ");
            if (Console.ReadLine() != "s")
            {
                redefine = false;
                tentativa = false;
            }
            else
            {
                Console.Write("Qual sua nova senha? ");
                users[login] = Console.ReadLine();

                redefine = true;
            }
        }
        else
        {
            tentativa = true;
        }
    }
}

Console.WriteLine("Programa Encerrado.");

