using OnlineCourse.Microservice.Catalog.Api.Features.Courses.Create;

namespace OnlineCourse.Microservice.Catalog.Api.Features.Courses
{
    public class CourseMapping: Profile
    {
        public CourseMapping()
        {
            CreateMap<CreateCourseCommand, Course>();

        }
    }
}
