using BookShare.Domain.Entities;
using System.Collections.Generic;

namespace BookShare.Application.Interface
{
    public interface ILivroAppService : IAppServiceBase<Livro>
    {
        IEnumerable<Livro> GetByName(string nome);
        IEnumerable<Livro> LivroPorAutor(Autor autor);
        IEnumerable<Livro> ObterLivrosDisponiveis();
    }
}
