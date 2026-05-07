namespace aula11
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
        public void Apresentacao()
        {
            Console.WriteLine($"{Nome} - {Idade} anos.");
        }

        public static void CadastroPessoa()
        {
            bool sair = false;
            while (!sair)
            {
                Console.Write("Digite o nome para cadastrar ou 'x' para sair.\n >> ");
                string nome = Console.ReadLine();
                if (nome == "x")
                {
                    sair = true;
                    Console.WriteLine("\nSaindo...");
                }
                else
                {
                    Console.Write("\nDigite a idade:\n >> ");
                    int idade = int.Parse(Console.ReadLine());
                    Pessoa novaPessoa = new Pessoa { Nome = nome, Idade = idade };
                    novaPessoa.Apresentacao();
                }
            }
        }
    }
}
