using AutoMapper;
using BookShare.Domain.Entities;
using BookShare.MVC.Models;

namespace BookShare.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings";  }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Livro, LivroViewModel>();
            Mapper.CreateMap<Autor, AutorViewModel>();
            Mapper.CreateMap<Categoria, CategoriaViewModel>();
            Mapper.CreateMap<Editora, EditoraViewModel>();

        }
    }
}