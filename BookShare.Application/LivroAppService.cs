using BookShare.Application.Interface;
using BookShare.Domain.Entities;
using System.Collections.Generic;
using BookShare.Domain.Interfaces.Services;

namespace BookShare.Application
{
    public class LivroAppService : AppServiceBase<Livro>, ILivroAppService
    {
        private readonly ILivroService _livroService;
        public LivroAppService(ILivroService livroService) : base(livroService)
        {
            _livroService = livroService;
        }

        public IEnumerable<Livro> GetByName(string nome)
        {
            return _livroService.GetByName(nome);
        }

        public IEnumerable<Livro> LivroPorAutor(Autor autor)
        {
            return _livroService.LivroPorAutor(autor);
        }

        public IEnumerable<Livro> ObterLivrosDisponiveis(IEnumerable<Livro> livros)
        {
            return _livroService.ObterLivrosDisponiveis(livros);
        }
    }
}
