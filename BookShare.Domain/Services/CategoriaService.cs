using BookShare.Domain.Entities;
using BookShare.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShare.Domain.Interfaces;

namespace BookShare.Domain.Services
{
    public class CategoriaService : ServiceBase<Categoria>, ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaService(ICategoriaRepository categoriaRepository) : base(categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IEnumerable<Categoria> GetByName(string nome)
        {
            return _categoriaRepository.GetByName(nome);
        }
    }
}
