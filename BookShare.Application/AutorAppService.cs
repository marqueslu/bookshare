using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using BookShare.Domain.Interfaces.Services;
using BookShare.Application.Interface;

namespace BookShare.Application
{
    public class AutorAppService : AppServiceBase<Autor>, IAutorAppService
    {
        private readonly IAutorService _autorService;
        public AutorAppService(IAutorService autorService) : base(autorService)
        {
            _autorService = autorService;
        }

        public IEnumerable<Autor> GetByName(string nome)
        {
          return  _autorService.GetByName(nome);
        }
    }
}
