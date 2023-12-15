using AutoMapper;
using Blazor.Business.Contracts;
using Blazor.Common;
using Blazor.DataAccess.Data;
using Blazor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Business.Implementation
{
    public class CourseOrderInfoRepository:ICourseOrderInfoRepository
    {
        private readonly BlazorContext _context;
        private readonly IMapper _mapper;

        public CourseOrderInfoRepository(BlazorContext ctx, IMapper mapper)
        {
            _context = ctx;
            _mapper = mapper;
        }

        public async Task<Result<CourseOrderInfoDto>> Create(CourseOrderInfoDto details)
        {
            try
            {
                var courseOrder = _mapper.Map<CourseOrderInfoDto, CourseOrderInfo>(details);
                courseOrder.Status = ResultConstant.Status_Pending;
                var result = await _context.CourseOrderInfos.AddAsync(courseOrder);
                await _context.SaveChangesAsync();
                var returnData = _mapper.Map<CourseOrderInfo, CourseOrderInfoDto>(result.Entity);
                return new Result<CourseOrderInfoDto>(true, ResultConstant.RecordCreateSuccessfully, returnData);
            }
            catch (Exception ex)
            {
                return new Result<CourseOrderInfoDto>(false, ex.Message.ToString());
            }
        }

        public async Task<Result<CourseOrderInfoDto>> GetCourseOrderInfo(int courseId)
        {
            try
            {
                var data = await _context.CourseOrderInfos.Include(c => c.Course).FirstOrDefaultAsync(c => c.Id == courseId);
                var info = _mapper.Map<CourseOrderInfo, CourseOrderInfoDto>(data);
                info.TotalCount = _context.Courses.Where(x => x.Id == courseId).ToList().Count;
                return new Result<CourseOrderInfoDto>(true, ResultConstant.RecordFound, info);
            }
            catch (Exception ex)
            {
                return new Result<CourseOrderInfoDto>(false, ex.Message.ToString());
            }
        }

        public Task<Result<CourseOrderInfoDto>> PaymentSuccessful(CourseOrderInfoDto details)
        {
            throw new NotImplementedException();
        }

        public Task<Result<bool>> UpdateCourseOrderStatus(int courseOrderId, string status)
        {
            throw new NotImplementedException();
        }
    }
}
