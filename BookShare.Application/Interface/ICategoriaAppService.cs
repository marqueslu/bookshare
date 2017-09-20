using BookShare.Domain.Entities;
using System.Collections.Generic;

namespace BookShare.Application.Interface
{
    public interface ICategoriaAppService : IAppServiceBase<Categoria>
    {
        IEnumerable<Categoria> GetByName(string nome);
    }
}
