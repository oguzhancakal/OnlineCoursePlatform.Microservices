﻿namespace OnlineCourse.Microservice.Catalog.Api.Features.Categories.GetById
{

    public record GetCategoryByIdQuery(Guid Id) : IRequestByServiceResult<CategoryDto>
    {

    }

    public class GetCategoryByIdQueryHandler(AppDbContext context, IMapper mapper)
       : IRequestHandler<GetCategoryByIdQuery, ServiceResult<CategoryDto>>
    {
        public async Task<ServiceResult<CategoryDto>> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var hasCategory = await context.Categories.FindAsync(request.Id, cancellationToken);

            if (hasCategory == null)
            {
                return ServiceResult<CategoryDto>.Error("Not Found", $"Category with Id '{request.Id}' was not found.", HttpStatusCode.NotFound);


            }
            var categoryDto = mapper.Map<CategoryDto>(hasCategory);
            return ServiceResult<CategoryDto>.SuccessAsOk(categoryDto);

        }
    }

    public static class GetCategoryByIdEndpoint
    {
        public static RouteGroupBuilder GetByIdCategoryGroupItemEndpoint(this RouteGroupBuilder group)
        {
            group.MapGet("/{id:guid}",
                    async (IMediator mediator, Guid id) =>
                        (await mediator.Send(new GetCategoryByIdQuery(id))).ToGenericResult())
                .WithName("GetByIdCategory");

            return group;
        }
    }
}
