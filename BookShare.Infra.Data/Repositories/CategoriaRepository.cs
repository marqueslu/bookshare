using System;
using System.Collections.Generic;
using BookShare.Domain.Entities;
using BookShare.Domain.Interfaces;
using System.Linq;

namespace BookShare.Infra.Data.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
    {
        public IEnumerable<Categoria> GetByName(string nome)
        {
            return Db.Categorias.Where(c => c.Nome == nome);
        }
    }
}
