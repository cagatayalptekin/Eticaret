﻿using Blazor.Common;
using Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Business.Contracts
{
    public interface ICourseOrderInfoRepository
    {
        public Task<Result<CourseOrderInfoDto>> Create(CourseOrderInfoDto details);
        public Task<Result<CourseOrderInfoDto>> PaymentSuccessful(CourseOrderInfoDto details);
        public Task<Result<CourseOrderInfoDto>> GetCourseOrderInfo(int courseId);
        public Task<Result<bool>> UpdateCourseOrderStatus(int courseOrderId, string status);

    }
}
