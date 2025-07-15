using BookStore.Data;
using BookStore.Models;

namespace BookStore.Menus
{

    internal class MenuMostrarLivros : Menu
    {
        public override void Executar(DAL<Autor> autorDAL)
        {
            base.Executar(autorDAL);
            ExibirTituloDaOpcao("Exibir detalhes do autor");
            Console.Write("Digite o nome do autor que deseja conhecer melhor: ");
            string nomeDoautor = Console.ReadLine()!;
            var autorRecuperado = autorDAL.RecuperarPor(a => a.Nome == nomeDoautor);

            if (autorRecuperado is not null)
            {

                autorRecuperado.ExibirLivros();
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO autor {nomeDoautor} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}