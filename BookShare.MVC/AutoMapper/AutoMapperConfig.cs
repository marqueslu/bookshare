using AutoMapper;
using BookShare.MVC.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShare.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
               {
                   x.AddProfile<DomainToViewModelMappingProfile>();
                   x.AddProfile<ViewModelToDomainMappinfProfile>();
               });
        }
    }
}