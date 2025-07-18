﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data
{
    internal class DAL<T> where T : class
    {
        protected readonly BookStoreContext context;

        public DAL(BookStoreContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> Listar()
        {
            return context.Set<T>().ToList();

        }

        public void Adicionar(T objeto)
        {
            context.Set<T>().Add(objeto);
            context.SaveChanges();
        }
        public void Atualizar(T objeto)
        {
            context.Set<T>().Update(objeto);
            context.SaveChanges();
        }
        public void Remover(T objeto)
        {
            context.Set<T>().Remove(objeto);
            context.SaveChanges();
        }
        public IEnumerable<T> ListarPor(Func<T, bool> condicao)
        {
            return context.Set<T>().Where(condicao);
        }
        public T? RecuperarPor(Func<T, bool> condicao)
        {
            return context.Set<T>().FirstOrDefault(condicao);
        }
    }
}
