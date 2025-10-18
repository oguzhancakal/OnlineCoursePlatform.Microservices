using MediatR;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using OnlineCourse.Microservice.Catalog.Api;
using OnlineCourse.Microservice.Catalog.Api.Features.Categories;
using OnlineCourse.Microservice.Catalog.Api.Features.Categories.Create;
using OnlineCourse.Microservice.Catalog.Api.Options;
using OnlineCourse.Microservice.Catalog.Api.Repositories;
using OnlineCourseMicroservice.Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOptionExt();
builder.Services.AddDatabaseServiceExt();   
builder.Services.AddCommonServices(typeof(CatalogAssembly));

var app = builder.Build();


app.AddCategoryGroupEndpointExt();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
} 

app.Run();
