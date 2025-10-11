using OnlineCourse.Microservice.Catalog.Api.Features.Courses;
using OnlineCourse.Microservice.Catalog.Api.Repositories;

namespace OnlineCourse.Microservice.Catalog.Api.Features.Categories
{
    public class Category: BaseEntity
    {
        public string Name { get; set; } = default!;
        public List<Course> Courses { get; set; } = new();

    }
}
