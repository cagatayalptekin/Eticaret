using AutoMapper;
using Blazor.DataAccess.Data;
using Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CourseDto, Course>().ReverseMap()
                .ForMember(c => c.ImageUrl, o => o.MapFrom<CourseItemUrlResolver>());

            CreateMap<CourseOrderInfo, CourseOrderInfoDto>().ReverseMap();
        }
    }
}
