using aula13;

Console.WriteLine("\n");
//exercício 1
Carro carro = new Carro("Toyota", "Corolla", 4);
carro.ExibirInfo();


Console.WriteLine("\n");
//exercício 2
Funcionario funcionario = new Funcionario("João", 30, "Gerente");
funcionario.ExibirInfo();


Console.WriteLine("\n");
//exercício 3
Retangulo retangulo = new Retangulo(5, 3);
Circulo circulo = new Circulo(4);

Console.WriteLine($"Área do Retângulo: {retangulo.CalcularArea()}");
Console.WriteLine($"Área do Círculo: {circulo.CalcularArea()}");


Console.WriteLine("\n");
//exercício 4
CLT clt = new CLT("Maria", 28, 5000);
PJ pj = new PJ("Carlos", 35, 40);


Console.WriteLine($"Salário CLT: {clt.CalcularSalario()}");
Console.WriteLine($"Salário PJ: {pj.CalcularSalario()}");

Console.WriteLine("\n");
//exercício 5


