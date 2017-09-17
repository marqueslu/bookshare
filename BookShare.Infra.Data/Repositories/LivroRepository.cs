using System;
using System.Collections.Generic;
using BookShare.Domain.Entities;
using BookShare.Domain.Interfaces;
using System.Linq;
using System.Data.Entity;

namespace BookShare.Infra.Data.Repositories
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
        public IEnumerable<Livro> GetByName(string nome)
        {
            return Db.Livros.Where(l => l.Titulo == nome);
        }

        public IEnumerable<Autor> LivroPorAutor(Autor autor)
        {
            IEnumerable<Autor> livros = (from a in Db.Autores
                                        .Include(l => l.Livros)
                                         where a.Nome.Contains(autor.Nome)
                                         select a).ToList();
            return livros;
        }
    }
}
