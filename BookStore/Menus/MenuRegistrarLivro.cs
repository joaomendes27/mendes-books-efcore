using BookStore.Data;
using BookStore.Models;

namespace BookStore.Menus
{

    internal class MenuRegistrarLivro : Menu
    {
        public override void Executar(DAL<Autor> autorDAL)
        {
            base.Executar(autorDAL);
            ExibirTituloDaOpcao("Registro de livros");
            Console.Write("Digite o autor cujo livros deseja registrar: ");
            string nomeAutor = Console.ReadLine()!;
            var autorRecuperado = autorDAL.RecuperarPor(a => a.Nome == nomeAutor);
            if (autorRecuperado is not null)
            {
                Console.Write("Agora digite o título do livro: ");
                string tituloDoLivro = Console.ReadLine()!;
                Console.Write("Agora digite o ano de lançamento do livro: ");
                string anoLancamento = Console.ReadLine()!;
                autorRecuperado.AdicionarLivro(new Livro(tituloDoLivro, Convert.ToInt32(anoLancamento)));
                Console.WriteLine($"O livro {tituloDoLivro} de {nomeAutor} foi registrado com sucesso!");
                autorDAL.Atualizar(autorRecuperado);
                Thread.Sleep(4000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO autor {nomeAutor} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}