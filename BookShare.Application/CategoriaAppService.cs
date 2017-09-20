using BookShare.Domain.Entities;
using System.Collections.Generic;
using BookShare.Domain.Interfaces.Services;

namespace BookShare.Application
{
    public class CategoriaAppService : AppServiceBase<Categoria>, ICategoriaService
    {
        private readonly ICategoriaService _categoriaService;
        public CategoriaAppService(ICategoriaService categoriaService) : base(categoriaService)
        {
            _categoriaService = categoriaService;
        }

        public IEnumerable<Categoria> GetByName(string nome)
        {
            return _categoriaService.GetByName(nome);
        }
    }
}
