﻿using OnlineCourse.Microservice.Catalog.Api.Features.Courses.Create;

namespace OnlineCourse.Microservice.Catalog.Api.Features.Courses
{
    public static class CourseEndpointExt
    {
        public static void AddCourseGroupEndpointExt(this WebApplication app)
        {
            app.MapGroup("api/courses").WithTags("Courses")
                .CreateCourseGroupItemEndpoint();

        }
    }
}
