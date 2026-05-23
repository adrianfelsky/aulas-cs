using A3_Adrian;

Carro carro1 = new Carro()
{
    Marca = "Toyota",
    Modelo = "Corolla",
    Ano = 2020,
    PrecoDiaria = 150.00,
    QuantidadePortas = 4
};

Carro carro2 = new Carro()
{
    Marca = "Honda",
    Modelo = "Civic",
    Ano = 2019,
    PrecoDiaria = 140.00,
    QuantidadePortas = 2
};

Moto moto1 = new Moto()
{
    Marca = "Yamaha",
    Modelo = "MT-07",
    Ano = 2021,
    PrecoDiaria = 100.00,
    Cilindrada = 689
};

Moto moto2 = new Moto()
{
    Marca = "Kawasaki",
    Modelo = "Ninja 400",
    Ano = 2020,
    PrecoDiaria = 90.00,
    Cilindrada = 399
};

Caminhao caminhao1 = new Caminhao()
{
    Marca = "Volvo",
    Modelo = "FH16",
    Ano = 2018,
    PrecoDiaria = 300.00,
    CapacidadeCarga = 20
};

Caminhao caminhao2 = new Caminhao()
{
    Marca = "Scania",
    Modelo = "R500",
    Ano = 2019,
    PrecoDiaria = 320.00,
    CapacidadeCarga = 25
};

List<Veiculo> veiculos = new List<Veiculo>() { carro1, carro2, moto1, moto2, caminhao1, caminhao2 };


while (true)
{
    Console.Clear();
    Console.WriteLine("######### SISTEMA DE LOCAÇÃO DE VEÍCULOS #########\n");
    Console.WriteLine("Escolha um veículo para calcular o custo de locação:\n");
    int index = 1;
    foreach (Veiculo veiculo in veiculos)
    {
        Console.WriteLine($"{index}. {veiculo.Marca} {veiculo.Modelo}");
        index++;
    }
    Console.Write("0. Sair\n\n >> ");
    int escolha;
    while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 0 || escolha > veiculos.Count)
    {
        Console.Write("Por favor, insira uma opção válida.\n >> ");
    }

    if (escolha == 0)
    {
        break;
    }
    Veiculo veiculoSelecionado = veiculos[escolha - 1];
    int dias;
    Console.Write($"\nVocê selecionou {veiculoSelecionado.Marca} - {veiculoSelecionado.Modelo}.\nSerão quantos dias de locação?\n\n >> ");
    while (!int.TryParse(Console.ReadLine(), out dias) || dias <= 0)
    {
        Console.Write("Por favor, insira uma quantidade válida de dias (maior que 0):\n >> ");
    }
    Console.WriteLine();
    veiculoSelecionado.ExibirInformacoes();
    Console.WriteLine($"\nCusto para {dias} dias: {veiculoSelecionado.CalcularLocacao(dias)}");
    Console.Write("\nDeseja calcular para outro veículo? (s/n)\n\n >> ");
    if (Console.ReadLine() != "s")
    {
        break;
    }
}

Console.WriteLine("\nEncerrando o programa...");

