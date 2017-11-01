using BookShare.Application.Interface;
using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShare.Domain.Interfaces.Services;

namespace BookShare.Application
{
    public class EditoraAppService : AppServiceBase<Editora>, IEditoraAppService
    {
        private readonly IEditoraService _editoraService;
        public EditoraAppService(IEditoraService editoraService) : base(editoraService)
        {
            _editoraService = editoraService;
        }

        public IEnumerable<Editora> GetByName(string nome)
        {
            return _editoraService.GetByName(nome);
        }
    }
}
