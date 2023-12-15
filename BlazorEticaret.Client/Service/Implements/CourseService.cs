using Blazor.Common;
using Blazor.Models;
using BlazorEticaret.Client.Service.Contracts;
using Newtonsoft.Json;

namespace BlazorEticaret.Client.Service.Implements
{
    public class CourseService:ICourseService
    {
        private readonly HttpClient _httpClient;

        public CourseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Result<IEnumerable<CourseDto>>> GetAllCourse()
        {
            var response = await _httpClient.GetAsync($"api/Course");
            var content = await response.Content.ReadAsStringAsync();
            var courses = JsonConvert.DeserializeObject<IEnumerable<CourseDto>>(content);
            return new Result<IEnumerable<CourseDto>>(true, ResultConstant.RecordFound, courses);
        }

        public async Task<Result<CourseDto>> GetCourse(int courseId)
        {
            var response = await _httpClient.GetAsync($"api/Course/" + courseId);
            var content = await response.Content.ReadAsStringAsync();
            var courses = JsonConvert.DeserializeObject<CourseDto>(content);
            return new Result<CourseDto>(true, ResultConstant.RecordFound, courses);
        }
    }
}
