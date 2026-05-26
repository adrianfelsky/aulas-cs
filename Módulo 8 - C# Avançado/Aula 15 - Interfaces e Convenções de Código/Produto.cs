namespace Aula15
{
    public class Produto : ICalculavel, IDescricao
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double Calcular()
        {
            return Preco * Quantidade;
        }
        public string Descrever()
        {
            return $"Produto: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}";
        }

    }
}
