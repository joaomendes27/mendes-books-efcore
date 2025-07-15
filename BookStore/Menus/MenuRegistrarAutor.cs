using BookStore.Data;
using BookStore.Models;

namespace BookStore.Menus
{
    internal class MenuRegistrarAutor : Menu
    {
        public override void Executar(DAL<Autor> autorDAL)
        {
            base.Executar(autorDAL);
            ExibirTituloDaOpcao("Registro dos autores");
            Console.Write("Digite o nome do autor que deseja registrar: ");
            string nomeAutor = Console.ReadLine()!;
            Console.Write("Digite a bio do autor que deseja registrar: ");
            string bioAutor = Console.ReadLine()!;
            Autor autor = new Autor(nomeAutor, bioAutor);
            autorDAL.Adicionar(autor);
            Console.WriteLine($"O autor {nomeAutor} foi registrado com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }
}