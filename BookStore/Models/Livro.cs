using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }

        public virtual Autor Autor { get; set; }

        public Livro() { }

        public Livro(string titulo, int anoPublicacao)
        {
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
        }

        public override string ToString()
        {
            return $"ID: {Id} \n" +
                $"Titulo: {Titulo} \n" +
                $"Ano Publicação: {AnoPublicacao}";
        }
    }
}
