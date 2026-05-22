namespace aula13
{
    class CLT : FuncionarioTipo
    {
        public double Salario { get; set; }
        public CLT(string nome, int idade, double salario) : base(nome, idade)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        public override double CalcularSalario()
        {
            return Salario; 
        }
    }
}
