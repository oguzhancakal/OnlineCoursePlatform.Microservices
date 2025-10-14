using MediatR;
using OnlineCourseMicroservice.Shared;

namespace OnlineCourse.Microservice.Catalog.Api.Features.Categories.Create
{
    public record CreateCategoryCommand(string Name): IRequest<ServiceResult<CreateCategoryResponse>>;
    
   
}
