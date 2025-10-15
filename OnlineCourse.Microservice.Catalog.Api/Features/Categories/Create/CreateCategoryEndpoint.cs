using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.Microservice.Catalog.Api.Features.Categories.Create
{
    public static class CreateCategoryEndpoint
    {
        public static RouteGroupBuilder CreateCategoryEndpointExt(this RouteGroupBuilder group)
        {
            group.MapPost("/", async (CreateCategoryCommand command, IMediator mediator) =>
            {
                var result = await mediator.Send(command);

                return new ObjectResult(result)
                {
                    StatusCode = result.Status.GetHashCode()
                };
            });
                return group;
        }
    }
}
