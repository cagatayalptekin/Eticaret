using Blazor.Common;
using Blazor.Models;
using System.Threading.Tasks;

namespace BlazorEticaret.Client.Service.Contracts
{
    public interface ICourseOrderInfoService
    {
        public Task<Result<CourseOrderInfoDto>> SaveCourseOrderInfo(CourseOrderInfoDto model);
        public Task<Result<CourseOrderInfoDto>> PaymentSuccessful(int courseId);
    }
}