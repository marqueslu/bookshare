using BookShare.Domain.Entities;
using BookShare.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Infra.Data.Repositories
{
    public class EditoraRepository : RepositoryBase<Editora>, IEditoraRepository
    {
        public IEnumerable<Editora> GetByName(string nome)
        {
            return Db.Editoras.Where(e => e.Nome == nome);
        }
    }
}
