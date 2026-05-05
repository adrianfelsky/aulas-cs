using aula10;

//anotações da aula
Console.WriteLine("############################\n\nAnotações da aula 10");

Aluno aluno1 = new Aluno()
{
    Nome = "João",
    Idade = 75,
    Sexo = "Masculino"

};

Aluno aluno2 = new Aluno()
{
    Nome = "Paulo",
    Idade = 35,
    Sexo = "Masculino"


};

Aluno aluno3 = new Aluno()
{
    Nome = "Maria",
    Idade = 27,
    Sexo = "Feminino"


};

aluno1.Apresentar();
aluno2.Apresentar();

Console.WriteLine($"{aluno3.Nome} - Aposentado: {(aluno3.VerificarAposentadoria() ? "sim" : "não")}");

// exercício1:
Console.WriteLine("\n\n############################\n\nExercício 1");
Carro carro1 = new Carro()
{
    Marca = "Toyota",
    Modelo = "Corolla",
    Ano = 2020,
    Cor = "Prata"
};

Carro carro2 = new Carro()
{
    Marca = "Honda",
    Modelo = "Civic",
    Ano = 2018,
    Cor = "Preto"
};

Console.WriteLine($""""
    
    {carro1.Marca}
    {carro1.Modelo}

    """");

carro1.ExibirInformacoes();
Console.WriteLine("\n----------\n");
carro2.ExibirInformacoes();

// exercício2:
Console.WriteLine("\n\n############################\n\nExercício 2");

Pessoa pessoa1 = new Pessoa()
{
    Nome = "Ana",
    Idade = 30,
};

Pessoa pessoa2 = new Pessoa()
{
    Nome = "Carlos",
    Idade = 17,
};

pessoa2.Apresentar();

// exercício3:
Console.WriteLine("\n\n############################\n\nExercício 3");

Produto produto1 = new Produto()
{
    Nome = "Notebook",
    Preco = 3500.00,
};

Produto produto2 = new Produto()
{
    Nome = "Smartphone",
    Preco = 1500.00,
};

produto1.ExibirInformacoes();
Console.WriteLine("\n----------\n");
produto2.ExibirInformacoes();

// exercício4:
Console.WriteLine("\n\n############################\n\nExercício 4");

ContaBancaria conta1 = new ContaBancaria()
{
    Titular = "12345-6",
    Saldo = 1000.00,
};

conta1.ExibirSaldo();

// exercício5:
Console.WriteLine("\n\n############################\n\nExercício 5");

AlunoExtra alunoExtra1 = new AlunoExtra()
{
    Nome = "Lucas",
    Nota = 8.5,
};

AlunoExtra alunoExtra2 = new AlunoExtra()
{
    Nome = "Sofia",
    Nota = 6.0,
};

alunoExtra1.Aprovacao();
alunoExtra2.Aprovacao();