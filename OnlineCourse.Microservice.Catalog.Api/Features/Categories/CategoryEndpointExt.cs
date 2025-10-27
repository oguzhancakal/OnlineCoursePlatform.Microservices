using OnlineCourse.Microservice.Catalog.Api.Features.Categories.Create;
using OnlineCourse.Microservice.Catalog.Api.Features.Categories.GetAll;
using OnlineCourse.Microservice.Catalog.Api.Features.Categories.GetById;

namespace OnlineCourse.Microservice.Catalog.Api.Features.Categories
{
    public static class CategoryEndpointExt
    {
        public static void AddCategoryGroupEndpointExt(this WebApplication app)
        {
            app.MapGroup("api/categories").WithTags("Categories")
                .CreateCategoryGroupItemEndpoint()
                .GetAllCategoryGroupItemEndpoint()
                .GetByIdCategoryGroupItemEndpoint();


        }
    }
}
