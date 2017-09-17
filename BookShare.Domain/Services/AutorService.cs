using System;
using System.Collections.Generic;
using BookShare.Domain.Entities;
using BookShare.Domain.Interfaces;
using BookShare.Domain.Interfaces.Services;

namespace BookShare.Domain.Services
{
    public class AutorService : ServiceBase<Autor>, IAutorService
    {
        private readonly IAutorRepository _autorRepository;
        public AutorService(IAutorRepository autorRepository) : base(autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public IEnumerable<Autor> GetByName(string nome)
        {
            return _autorRepository.GetByName(nome);
        }
    }
}
