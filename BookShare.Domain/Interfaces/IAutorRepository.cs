using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Interfaces
{
    public interface IAutorRepository : IRepositoryBase<Autor>
    {
        IEnumerable<Autor> GetByName(string nome);
    }
}
