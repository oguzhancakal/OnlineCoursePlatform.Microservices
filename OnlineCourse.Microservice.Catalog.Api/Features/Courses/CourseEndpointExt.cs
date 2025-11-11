using Asp.Versioning.Builder;
using OnlineCourse.Microservice.Catalog.Api.Features.Courses.Create;
using OnlineCourse.Microservice.Catalog.Api.Features.Courses.Delete;
using OnlineCourse.Microservice.Catalog.Api.Features.Courses.GetAll;
using OnlineCourse.Microservice.Catalog.Api.Features.Courses.GetAllByUserId;
using OnlineCourse.Microservice.Catalog.Api.Features.Courses.GetById;
using OnlineCourse.Microservice.Catalog.Api.Features.Courses.Update;


namespace OnlineCourse.Microservice.Catalog.Api.Features.Courses
{
    public static class CourseEndpointExt
    {
        public static void AddCourseGroupEndpointExt(this WebApplication app, ApiVersionSet apiVersionSet)
        {
            app.MapGroup("api/v{version:apiVersion}/courses").WithTags("Courses").WithApiVersionSet(apiVersionSet)
                .CreateCourseGroupItemEndpoint()
                .GetAllCourseGroupItemEndpoint()
                .GetAByIdCourseGroupItemEndpoint()
                .UpdateCourseGroupItemEndpoint()
                .DeleteCourseGroupItemEndpoint()
                .GetByUserIdCourseGroupItemEndpoint();


        }
    }
}
