using AutoMapper;
using OnlineCourse.Microservice.Catalog.Api.Features.Categories.Dtos;

namespace OnlineCourse.Microservice.Catalog.Api.Features.Categories
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
