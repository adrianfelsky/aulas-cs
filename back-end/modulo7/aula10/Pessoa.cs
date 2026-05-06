namespace aula10
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e nasci em {(DateTime.Now.Year) - Idade}.");
        }
    }
}
