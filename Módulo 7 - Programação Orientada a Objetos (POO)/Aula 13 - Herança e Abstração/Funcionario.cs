namespace aula13
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public Funcionario(string nome, int idade, string cargo) : base(nome, idade)
        {
            Nome = nome;
            Idade = idade;
            Cargo = cargo;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Cargo: {Cargo}");
        }
    }
}
