using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchi.Domain.Entities;
using CleanArchi.Application.ViewModels;


namespace CleanArchi.Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
