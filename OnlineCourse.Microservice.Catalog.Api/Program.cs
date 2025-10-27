using OnlineCourse.Microservice.Catalog.Api;
using OnlineCourse.Microservice.Catalog.Api.Features.Categories;
using OnlineCourse.Microservice.Catalog.Api.Features.Courses;
using OnlineCourse.Microservice.Catalog.Api.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOptionExt();
builder.Services.AddDatabaseServiceExt();   
builder.Services.AddCommonServices(typeof(CatalogAssembly));


var app = builder.Build();


app.AddCategoryGroupEndpointExt();
app.AddCourseGroupEndpointExt();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
