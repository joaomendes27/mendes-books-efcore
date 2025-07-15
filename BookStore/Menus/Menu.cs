using BookStore.Data;
using BookStore.Models;

namespace BookStore.Menus
{

    internal class Menu
    {
        public void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }
        public virtual void Executar(DAL<Autor> autorDAL)
        {
            Console.Clear();
        }
    }
}