using BookShare.Application.Interface;
using BookShare.Domain.Entities;
using BookShare.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace BookShare.Application
{
    public class CategoriaAppService : AppServiceBase<Categoria>, ICategoriaAppService
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
