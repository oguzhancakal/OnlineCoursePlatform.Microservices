using OnlineCourse.Microservice.Catalog.Api.Features.Courses.Create;
using OnlineCourse.Microservice.Catalog.Api.Features.Courses.Delete;
using OnlineCourse.Microservice.Catalog.Api.Features.Courses.GetAll;
using OnlineCourse.Microservice.Catalog.Api.Features.Courses.GetById;
using OnlineCourse.Microservice.Catalog.Api.Features.Courses.Update;


namespace OnlineCourse.Microservice.Catalog.Api.Features.Courses
{
    public static class CourseEndpointExt
    {
        public static void AddCourseGroupEndpointExt(this WebApplication app)
        {
            app.MapGroup("api/courses").WithTags("Courses")
                .CreateCourseGroupItemEndpoint()
                .GetAllCourseGroupItemEndpoint()
                .GetAByIdCourseGroupItemEndpoint()
                .UpdateCourseGroupItemEndpoint()
                .DeleteCourseGroupItemEndpoint();




        }
    }
}
