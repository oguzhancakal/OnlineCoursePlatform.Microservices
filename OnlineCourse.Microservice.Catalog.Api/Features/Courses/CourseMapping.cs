using OnlineCourse.Microservice.Catalog.Api.Features.Courses.Create;
using OnlineCourse.Microservice.Catalog.Api.Features.Courses.Dtos;

namespace OnlineCourse.Microservice.Catalog.Api.Features.Courses
{
    public class CourseMapping: Profile
    {
        public CourseMapping()
        {
            CreateMap<CreateCourseCommand, Course>();
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Feature, FeatureDto>().ReverseMap();

        }
    }
}
