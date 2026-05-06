namespace aula11
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
        public void Apresentacao()
        {
            Console.WriteLine($"{Nome} tem {Idade} anos.");
        }
    }
}
