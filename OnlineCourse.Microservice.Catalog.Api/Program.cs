using OnlineCourse.Microservice.Catalog.Api;
using OnlineCourse.Microservice.Catalog.Api.Features.Categories;
using OnlineCourse.Microservice.Catalog.Api.Features.Courses;
using OnlineCourse.Microservice.Catalog.Api.Options;
using OnlineCourse.Microservice.Catalog.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOptionExt();
builder.Services.AddDatabaseServiceExt();   
builder.Services.AddCommonServices(typeof(CatalogAssembly));
builder.Services.AddVersioningExt();


var app = builder.Build();


await app.AddSeedDataExt().ContinueWith(x =>
{
    Console.WriteLine(x.IsFaulted ? x.Exception?.Message : "Seed data has been saved successfully");
});

app.AddCategoryGroupEndpointExt(app.AddVersionSetExt());
app.AddCourseGroupEndpointExt(app.AddVersionSetExt());


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
