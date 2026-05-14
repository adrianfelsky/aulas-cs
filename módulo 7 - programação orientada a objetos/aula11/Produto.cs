namespace aula11
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Produto: {Nome}, Preço: R${Preco}");
        }
    }
}
