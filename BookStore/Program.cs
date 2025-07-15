using BookStore.Data; 
using BookStore.Models;
using BookStore.Menus;
using System;


var context = new BookStoreContext();
var autorDAL = new DAL<Autor>(context);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarAutor());
opcoes.Add(2, new MenuRegistrarLivro());
opcoes.Add(3, new MenuMostrarLivros());
opcoes.Add(4, new MenuMostrarAutores());
opcoes.Add(5, new MenuMostrarLivrosPorAno());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"
  __  __                _            ____              _        
 |  \/  |              | |          |  _ \            | |       
 | \  / | ___ _ __   __| | ___ ___  | |_) | ___   ___ | | _____ 
 | |\/| |/ _ \ '_ \ / _` |/ _ \ __| |  _ ; / _ \ / _ \| |/ / __|
 | |  | |  __/ | | | (_| |  __\__ \ | |_) | (_) | (_) |   \__ \
 |_|  |_|\___|_| |_|\__,_|\___|___/ |____/ \___/ \___/|_|\_\___/
                                                                
                                                              
");
    Console.WriteLine("Boas vindas ao Mendes Books!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um Autor");
    Console.WriteLine("Digite 2 para registrar o Livro de um autor");
    Console.WriteLine("Digite 3 para exibir todos os livros de um autor");
    Console.WriteLine("Digite 4 para mostrar todos os Autores");
    Console.WriteLine("Digite 5 para exibir os livros por ano de lançamento");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(autorDAL);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ExibirOpcoesDoMenu();