using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShare.Domain.Interfaces;
using BookShare.Domain.Interfaces.Services;

namespace BookShare.Domain.Services
{
    public class LivroService : ServiceBase<Livro>, ILivroService
    {
        private readonly ILivroRepository _livroRepository;
        public LivroService(ILivroRepository livroRepository) : base(livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public IEnumerable<Livro> GetByName(string nome)
        {
            return _livroRepository.GetByName(nome);
        }

        public IEnumerable<Livro> LivroPorAutor(Autor autor)
        {
            return _livroRepository.LivroPorAutor(autor);
        }

        public IEnumerable<Livro> ObterLivrosDisponiveis(IEnumerable<Livro> livros)
        {
            return livros.Where(l => l.StatusLivro(l));
        }
    }
}
