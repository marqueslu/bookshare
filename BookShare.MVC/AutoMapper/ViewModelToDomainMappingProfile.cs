using AutoMapper;
using BookShare.Domain.Entities;
using BookShare.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShare.MVC.AutoMapper
{
    public class ViewModelToDomainMappinfProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<LivroViewModel, Livro>();
            Mapper.CreateMap<AutorViewModel, Autor>();
            Mapper.CreateMap<CategoriaViewModel, Categoria>();
            Mapper.CreateMap<EditoraViewModel, Editora>();

        }
    }
}