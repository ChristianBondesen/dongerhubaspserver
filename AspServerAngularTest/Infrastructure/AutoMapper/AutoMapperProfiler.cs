using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspServerAngularTest.Models;
using AspServerAngularTest.Models.AccountViewModels;
using AutoMapper;

namespace AspServerAngularTest.Infrastructure.AutoMapper
{
    public class AutoMapperProfiler : Profile
    {
        public AutoMapperProfiler()
        {
            CreateMap<RegisterViewModel, ApplicationUser>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }
    }
}
