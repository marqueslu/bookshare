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

        public IEnumerable<Livro> LivroPorAutor(Autor autor)
        {
            IEnumerable<Livro> livros = (from l in Db.Livros
                                        .Include(a => a.Autor)
                                         where l.Autor.Nome.Contains(autor.Nome)
                                         select l).ToList();
            return livros;
        }
    }
}
