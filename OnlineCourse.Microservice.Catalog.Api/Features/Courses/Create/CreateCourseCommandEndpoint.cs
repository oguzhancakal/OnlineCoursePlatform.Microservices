using Microsoft.AspNetCore.Mvc;
using OnlineCourseMicroservice.Shared.Filters;


namespace OnlineCourse.Microservice.Catalog.Api.Features.Courses.Create
{
    public static class CreateCourseCommandEndpoint
    {
        public static RouteGroupBuilder CreateCourseGroupItemEndpoint(this RouteGroupBuilder group)
        {
            group.MapPost("/",
                    async ([FromForm] CreateCourseCommand command, IMediator mediator) =>
                    (await mediator.Send(command)).ToGenericResult())
                .WithName("CreateCourse")

                .Produces<Guid>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status404NotFound)
                .Produces<ProblemDetails>(StatusCodes.Status400BadRequest)
                .Produces<ProblemDetails>(StatusCodes.Status500InternalServerError)
                .AddEndpointFilter<ValidationFilter<CreateCourseCommand>>().DisableAntiforgery();
               

            return group;
        }
    }
}
