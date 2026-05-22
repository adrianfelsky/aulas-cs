namespace aula13
{
    public abstract class FuncionarioTipo : Pessoa
    {
        public FuncionarioTipo(string nome, int idade) : base(nome, idade)
        {
            Nome = nome;
            Idade = idade;
        }
        //public override void ExibirInfo()
        //{
        //    base.ExibirInfo();
        //}

        public abstract double CalcularSalario();
    }
}
