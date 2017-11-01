using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Application.Interface
{
    public interface IEditoraAppService : IAppServiceBase<Editora>
    {
        IEnumerable<Editora> GetByName(string nome);
    }
}
