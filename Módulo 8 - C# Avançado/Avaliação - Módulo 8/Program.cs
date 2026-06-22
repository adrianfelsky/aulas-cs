using BibliotecaApp.Modelos;
using BibliotecaApp.Repositorios;
using BibliotecaApp.Excecoes;
using BibliotecaApp.Servicos;
using ConsoleTables;

static void PausaParaLer()
{
    Console.Write("\nDigite ENTER para continuar...");
    Console.ReadLine();
}

static void ExibirTabela(List<Livro> livros)
{
    var table = new ConsoleTable("ID", "Autor", "Titulo", "Ano", "Disponível");

    foreach (var livro in livros)
    {
        table.AddRow(livro.ID, livro.Autor, livro.Titulo ,livro.Ano, livro.Disponivel);
    }

    table.Write();
}


List<Livro> livros = new List<Livro>
{
    new Livro(1,  "Dom Casmurro",                      "Machado de Assis",          1899, true),
    new Livro(2,  "Memórias Póstumas de Brás Cubas",   "Machado de Assis",          1881, false),
    new Livro(3,  "O Cortiço",                          "Aluísio Azevedo",           1890, true),
    new Livro(4,  "Grande Sertão: Veredas",            "João Guimarães Rosa",       1956, true),
    new Livro(5,  "Vidas Secas",                        "Graciliano Ramos",          1938, false),
    new Livro(6,  "Capitães da Areia",                  "Jorge Amado",               1937, true),
    new Livro(7,  "A Hora da Estrela",                  "Clarice Lispector",         1977, true),
    new Livro(8,  "O Hobbit",                           "J.R.R. Tolkien",            1937, false),
    new Livro(9,  "1984",                               "George Orwell",             1949, true),
    new Livro(10, "O Senhor dos Anéis",                 "J.R.R. Tolkien",            1954, true),
    new Livro(11, "Cem Anos de Solidão",                "Gabriel García Márquez",    1967, false),
    new Livro(12, "Crime e Castigo",                    "Fiódor Dostoiévski",        1866, true),
    new Livro(13, "Orgulho e Preconceito",              "Jane Austen",               1813, true),
    new Livro(14, "O Pequeno Príncipe",                 "Antoine de Saint-Exupéry",  1943, false),
    new Livro(15, "Fahrenheit 451",                     "Ray Bradbury",              1953, true),
    new Livro(16, "Admirável Mundo Novo",               "Aldous Huxley",             1932, true),
    new Livro(17, "O Conde de Monte Cristo",            "Alexandre Dumas",           1844, false),
    new Livro(18, "Drácula",                            "Bram Stoker",               1897, true),
    new Livro(19, "Frankenstein",                       "Mary Shelley",              1818, true),
    new Livro(20, "A Revolução dos Bichos",             "George Orwell",             1945, false)
};

AcervoService acervoService = new AcervoService();

if (acervoService.Acervo.Count == 0)
{
    acervoService.Acervo.AddRange(livros);
}

BibliotecaApiService apiService = new BibliotecaApiService(new HttpClient());

RepositorioLivro repositorio = new RepositorioLivro();
foreach (var livro in acervoService.Acervo)
{
    repositorio.Adicionar(livro);
}

bool sair = false;
while (!sair)
{

    Console.Clear();
    Console.WriteLine("\n-- Sistema de Gerenciamento de Biblioteca --\n");
    Console.WriteLine(" 1 - Listar Todos ");
    Console.WriteLine(" 2 - Buscar por Id");
    Console.WriteLine(" 3 - Buscar por Autor");
    Console.WriteLine(" 4 - Listar Disponíveis (async) ");
    Console.WriteLine(" 5 - Busca na API");
    Console.WriteLine(" 6 - Salvar Acervo - R9");
    Console.WriteLine(" 0 - sair");
    Console.Write("\nEscolha uma opção do Menu:\n\n >> ");
    string entrada = Console.ReadLine();

    //Console.Clear();
    switch (entrada)
    {
        case "1":
            Console.Clear();
            Console.WriteLine($"\n--- Livros incluídos na biblioteca ---\n");
            ExibirTabela(repositorio.ListarTodos());
            break;
        case "2":
            Console.Clear();
            Console.Write("\nDigite o ID do livro:\n\n >> ");
            if (int.TryParse(Console.ReadLine(), out int idBusca))
            {
                try
                {
                    var livroId = repositorio.BuscarPorId(idBusca);
                    Console.WriteLine("\n--- Produto Encontrado ---\n");
                    ExibirTabela(new List<Livro> { livroId });
                }
                catch (LivroNaoEncontradoException ex)
                {
                    Console.WriteLine($"\n[ERRO] {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("\n[ERRO] Formato de ID inválido. Digite um número inteiro.");
            }
            break;

        case "3":
            Console.Clear();
            Console.Write("\nDigite o nome do autor:\n\n >> ");
            string autor = Console.ReadLine();
            var livrosAutor = repositorio.BuscarPorAutor(autor);

            try
            {
                if (string.IsNullOrWhiteSpace(autor) || !livrosAutor.Any())
                {
                    throw new AutorNaoEncontradoException(autor);
                }

                Console.WriteLine($"\n--- Livros de \"{autor}\" ---\n");
                ExibirTabela(livrosAutor);
            }
            catch (AutorNaoEncontradoException ex)
            {
                Console.WriteLine($"\n[ERRO] {ex.Message}");
            }
            break;

        case "4":
            Console.Clear();
            Console.WriteLine("\nVerificando disponibilidade...");

            var disponiveis = await repositorio.ListarDisponiveisAsync();

            if (disponiveis.Count == 0)
            {
                Console.WriteLine("\nNenhum livro disponível no momento.");
            }
            else
            {
                Console.WriteLine("\n--- Livros disponíveis para empréstimo ---\n");
                ExibirTabela(disponiveis);
            }
            break;
        case "5":
            Console.Clear();
            Console.Write("\nDigite o título para buscar na API:\n\n >> ");
            string tituloBusca = Console.ReadLine();
            try
            {
                await apiService.BuscarDetalhesApiAsync(tituloBusca);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"\n[ERRO] Falha ao acessar a API: {ex.Message}");
            }
            break;
        case "6":
            Console.Clear();
            try
            {
                acervoService.SalvarAcervo();
                Console.WriteLine("\n[SUCESSO] Acervo salvo com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[ERRO] Falha ao salvar o arquivo: {ex.Message}");
            }
            break;
        case "0":
            sair = true;
            Console.WriteLine("\nEncerrando programa...");
            break;
        default:
            Console.WriteLine("\nDigite uma opção válida!");
            break;
    }

    if (!sair) PausaParaLer();
}
