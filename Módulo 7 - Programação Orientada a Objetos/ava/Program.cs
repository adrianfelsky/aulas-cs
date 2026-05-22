using System;
using System.Collections.Generic;

// 1. Instanciando pelo menos um objeto de cada tipo
Carro carro = new Carro
{
    Marca = "Toyota",
    Modelo = "Corolla",
    Ano = 2023,
    PrecoDiaria = 150.00m,
    QuantidadePortas = 4
};

Moto moto = new Moto
{
    Marca = "Honda",
    Modelo = "CB 500F",
    Ano = 2022,
    PrecoDiaria = 80.00m,
    Cilindrada = 500
};

Caminhao caminhao = new Caminhao
{
    Marca = "Volvo",
    Modelo = "FH 540",
    Ano = 2022,
    PrecoDiaria = 350.00m,
    // Passando o valor em toneladas (10). O 'set' vai converter para 10000 kg.
    CapacidadeCarga = 10 
};

// 2. Armazenando todos em uma List<Veiculo>
List<Veiculo> frota = new List<Veiculo> { carro, moto, caminhao };

int diasDeLocacao = 5;

// 3. Percorrendo a lista com um laço
foreach (Veiculo veiculo em frota)
{
    // Chama ExibirInformacoes() - O polimorfismo garante que o método da classe filha seja chamado
    veiculo.ExibirInformacoes();
    
    // Chama CalcularLocacao() e exibe o resultado
    decimal valorTotal = veiculo.CalcularLocacao(diasDeLocacao);
    Console.WriteLine($"Valor total da locação ({diasDeLocacao} dias): R$ {valorTotal:F2}");
    
    Console.WriteLine(new string('-', 30)); // Separador visual para o console
}
