using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Interfaces.Services
{
    public interface ILivroService : IServiceBase<Livro>
    {
        IEnumerable<Livro> GetByName(string nome);
        IEnumerable<Livro> LivroPorAutor(Autor autor);
        //IEnumerable<Livro> ObterLivrosDisponiveis(IEnumerable<Livro> livros);
    }
}
