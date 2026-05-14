namespace aula10
{
    class Aluno
    {
        //atributos
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public bool Aposentado { get; private set; } = false;

        //método
        public void Apresentar()
        {
            Aposentado=VerificarAposentadoria();
            Console.WriteLine($"{Nome} tem {Idade} anos,{Sexo.ToLower()} " +
                $"e {(Aposentado ? "" : "não ")}está aposentado(a).");
        }

        public bool VerificarAposentadoria()
        {
            return Idade > 65;
        }
    }
}
