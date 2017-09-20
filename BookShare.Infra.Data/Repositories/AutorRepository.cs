using System;
using System.Collections.Generic;
using BookShare.Domain.Entities;
using BookShare.Domain.Interfaces;
using System.Linq;

namespace BookShare.Infra.Data.Repositories
{
   public class AutorRepository : RepositoryBase<Autor>, IAutorRepository
    {
        public IEnumerable<Autor> GetByName(string nome)
        {
            return Db.Autores.Where(a => a.Nome == nome);
        }
    }
}
