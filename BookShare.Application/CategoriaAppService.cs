using BookShare.Domain.Entities;
using System.Collections.Generic;
using BookShare.Domain.Interfaces.Services;

namespace BookShare.Application
{
    public class CategoriaAppService : AppServiceBase<Categoria>, ICategoriaService
    {
        private readonly ICategoriaService _categoriaSerivce;
        public CategoriaAppService(ICategoriaService categoriaService) : base(categoriaService)
        {
            _categoriaSerivce = categoriaService;
        }

        public IEnumerable<Categoria> GetByName(string nome)
        {
            return _categoriaSerivce.GetByName(nome);
        }
    }
}
