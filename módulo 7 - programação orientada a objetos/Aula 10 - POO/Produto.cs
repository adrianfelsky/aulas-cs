namespace aula10
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preço: R${Preco}");
        }
    }
}
