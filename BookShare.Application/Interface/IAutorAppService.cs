using BookShare.Domain.Entities;
using System.Collections.Generic;

namespace BookShare.Application.Interface
{
    public interface IAutorAppService : IAppServiceBase<Autor>
    {
        IEnumerable<Autor> GetByName(string nome);
    }
}
