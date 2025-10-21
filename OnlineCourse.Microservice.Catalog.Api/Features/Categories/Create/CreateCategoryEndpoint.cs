using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseMicroservice.Shared.Extensions;
using UdemyNewMicroservice.Shared.Filters;

namespace OnlineCourse.Microservice.Catalog.Api.Features.Categories.Create
{
    public static class CreateCategoryEndpoint
    {
        public static RouteGroupBuilder CreateCategoryGroupItemEndpoint(this RouteGroupBuilder group)
        {
            group.MapPost("/", async (CreateCategoryCommand command, IMediator mediator) => 
            (await mediator.Send(command)).ToGenericResult())
                .AddEndpointFilter<ValidationFilter<CreateCategoryCommand>>(); 


            return group;
        }
    }
}
