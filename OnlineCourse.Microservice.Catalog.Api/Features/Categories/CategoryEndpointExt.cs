using Asp.Versioning.Builder;
using OnlineCourse.Microservice.Catalog.Api.Features.Categories.Create;
using OnlineCourse.Microservice.Catalog.Api.Features.Categories.GetAll;
using OnlineCourse.Microservice.Catalog.Api.Features.Categories.GetById;

namespace OnlineCourse.Microservice.Catalog.Api.Features.Categories
{
    public static class CategoryEndpointExt
    {
        public static void AddCategoryGroupEndpointExt(this WebApplication app, ApiVersionSet apiVersionSet)
        {
            app.MapGroup("api/v{version:apiVersion}/categories").WithTags("Categories")
                .WithApiVersionSet(apiVersionSet)
                .CreateCategoryGroupItemEndpoint()
                .GetAllCategoryGroupItemEndpoint()
                .GetByIdCategoryGroupItemEndpoint();


        }
    }
}
