using BookStore.Data;
using BookStore.Models;

namespace BookStore.Menus
{
    internal class MenuMostrarLivrosPorAno : Menu
    {
        public override void Executar(DAL<Autor> autorDAL)
        {
            base.Executar(autorDAL);
            ExibirTituloDaOpcao("Mostrar Livros por ano de lançamento");
            Console.Write("Digite o ano para consultar livros:");
            string anoLancamento = Console.ReadLine()!;
            var livroDal = new DAL<Livro>(new BookStoreContext());
            var listaAnoLancamento = livroDal.ListarPor(a => a.AnoPublicacao == Convert.ToInt32(anoLancamento));
            if (listaAnoLancamento.Any())
            {
                Console.WriteLine($"\nlivros do Ano {anoLancamento}:");
                foreach (var livro in listaAnoLancamento)
                {
                    Console.WriteLine(livro.ToString());
                }
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO ano {anoLancamento} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}