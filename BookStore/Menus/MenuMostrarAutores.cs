using BookStore.Data;
using BookStore.Models;

namespace BookStore.Menus
{

    internal class MenuMostrarAutores : Menu
    {
        public override void Executar(DAL<Autor> autorDAL)
        {
            base.Executar(autorDAL);
            ExibirTituloDaOpcao("Exibindo todos os autores registrados na nossa aplicação");

            foreach (var autor in autorDAL.Listar())
            {
                Console.WriteLine(autor);
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}