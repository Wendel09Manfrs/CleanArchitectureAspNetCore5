using AutoMapper;
using CleanArchi.Application.ViewModels;
using CleanArchi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchi.Application.Mappings
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile() {
            CreateMap<ProductViewModel, Product>();
                }

    }
}
