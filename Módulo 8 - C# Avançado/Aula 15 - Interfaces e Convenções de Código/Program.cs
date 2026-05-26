using Aula15;

//exercicio 1
IFormaGeometrica retangulo = new Retangulo(5, 3);
IFormaGeometrica circulo = new Circulo(4);

Console.WriteLine($"Área do retângulo: {retangulo.CalcularArea()}\nPerímetro do retângulo: {retangulo.CalcularPerimetro()}\n");
Console.WriteLine($"Área do círculo: {circulo.CalcularArea()}\nPerímetro do círculo: {circulo.CalcularPerimetro()}\n");

//exercicio 2

Produto produto1 = new Produto("Notebook", 3500.00, 3);
produto1.Descrever();