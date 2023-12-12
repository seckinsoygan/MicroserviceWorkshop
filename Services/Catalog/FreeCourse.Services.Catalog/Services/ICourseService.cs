using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Shared.Dtos;

namespace FreeCourse.Services.Catalog.Services
{
    public interface ICourseService
    {
        Task<Response<List<CourseDto>>> GetAllAsync();

        Task<Response<CourseDto>> GetByIdAsync(string Id);

        Task<Response<List<CourseDto>>> GetAllByUserId(string UserId);

        Task<Response<CourseDto>> CreateAsync(CourseCreateDto dto);

        Task<Response<NoContent>> UpdateAsync(CourseUpdateDto dto);

        Task<Response<NoContent>> DeleteAsync(string id);
    }
}
