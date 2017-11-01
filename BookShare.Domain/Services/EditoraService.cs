using BookShare.Domain.Entities;
using BookShare.Domain.Interfaces.Repositories;
using BookShare.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShare.Domain.Interfaces;

namespace BookShare.Domain.Services
{
    public class EditoraService : ServiceBase<Editora>, IEditoraService
    {
        private readonly IEditoraRepository _editoraRepository;

        public EditoraService(IEditoraRepository editoraRepository) : base(editoraRepository)
        {
            _editoraRepository = editoraRepository;
        }

        public IEnumerable<Editora> GetByName(string nome)
        {
            return _editoraRepository.GetByName(nome);
        }
    }
}
