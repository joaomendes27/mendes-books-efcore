using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome {  get; set; }
        public string Bio { get; set; }

        public virtual ICollection<Livro> Livros {  get; set; } = new List<Livro>();

        public Autor() { }

        public Autor (string nome, string bio)
        {
            Nome = nome;
            Bio = bio;
        }
        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void ExibirLivros()
        {
            Console.WriteLine($"Livros do autor: {Nome}\n");
            foreach( var livro in Livros)
            {
                Console.WriteLine($"Titulo: {livro.Titulo}\n Ano de Publicação: {livro.AnoPublicacao}");
                Console.WriteLine();
            }
        }
        public override string ToString()
        {
            return $"ID: {Id}\n" +
                $" Nome do Autor: {Nome} \n " +
                $"Bio: {Bio}";
        }

    }
}
