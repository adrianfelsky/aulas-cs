namespace aula11
{
    class Aluno
    {
        public string Nome;
        public int Idade;
        public float Nota;
        public bool VerificarSituacao()
        {
            Console.Write($"{Nome} - {Idade}: {Nota} -> ");
            if (Nota >= 7) { Console.WriteLine("Aprovado."); return true; }
            else { Console.WriteLine("Reprovado."); return false; }
        }

        public static void MediaTurma(float nota,int count)
        {
            float media = nota / count;
            Console.WriteLine($"Media da turma: {media}");
        }

        public static void CadastroAluno()
        { 
            bool sair = false;
            while (!sair)
            {
                int idade= 0;
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
                    idade = int.Parse(Console.ReadLine());
                    Pessoa novaPessoa = new Pessoa { Nome = nome, Idade = idade };
                    novaPessoa.Apresentacao();
                }

                Console.WriteLine("Digite a nota do aluno:");
                float nota = float.Parse(Console.ReadLine());

                Aluno novoAluno = new Aluno { Nome = nome, Idade = idade, Nota = nota };
            }
        }

    }
}
