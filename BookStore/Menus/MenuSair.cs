using BookStore.Data;
using BookStore.Models;

namespace BookStore.Menus
{

    internal class MenuSair : Menu
    {
        public override void Executar(DAL<Autor> autorDAL)
        {
            Console.WriteLine("Tchau tchau :)");
        }
    }
}