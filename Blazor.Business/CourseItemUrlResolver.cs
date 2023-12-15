using AutoMapper;
using Blazor.Common;
using Blazor.DataAccess.Data;
using Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Business
{
    public class CourseItemUrlResolver : IValueResolver<Course, CourseDto, string>
    {
        public string Resolve(Course source, CourseDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.ImageUrl))
                return ResultConstant.ImageServerUrl + source.ImageUrl;
            return null;
        }
    }
}
