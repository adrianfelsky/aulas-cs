# Sistema de Gerenciamento de Biblioteca

Este projeto é um aplicativo de console em C# desenvolvido como avaliação prática para o **Curso de C#** do programa **Entra21** (Módulo 08 — C# Avançado).

## 📝 O que o programa faz

O sistema foi criado para gerenciar o acervo de uma biblioteca, oferecendo as seguintes funcionalidades através de um menu interativo:

* **Listagem de Livros:** Exibe todos os livros cadastrados no acervo em ordem alfabética por título.
* **Busca por ID:** Permite localizar um livro específico através do seu identificador único.
* **Busca por Autor:** Filtra e exibe os livros escritos por um determinado autor.
* **Listagem Assíncrona:** Consulta e exibe de forma assíncrona apenas os livros que estão atualmente disponíveis para empréstimo.
* **Consulta à API Externa:** Conecta-se à API pública da *Open Library* para buscar e mostrar informações de livros diretamente da internet a partir de um título informado.
* **Persistência de Dados:** Salva e carrega automaticamente as informações do acervo em um arquivo local em formato JSON (`acervo.json`), garantindo que os dados não sejam perdidos ao fechar o programa.

## 👥 Integrantes do Grupo

O projeto foi desenvolvido por:

* Adrian Gazzani
* Gabriel Henrique Ce
* Eduardo Adão Locks
* José Rodrigues
* Everson Oliveira
