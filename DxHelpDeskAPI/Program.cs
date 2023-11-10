using DxHelpDeskAPI.Application.Interfaces;
using DxHelpDeskAPI.Application.Mappings;
using DxHelpDeskAPI.Domain.Interfaces;
using DxHelpDeskAPI.Extensions;
using DxHelpDeskAPI.Persistence.Repositories;
using DxHelpDeskAPI.Application.Services;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseMiddleware<ErrorHandlerMiddleware>();
app.ConfigureExceptionHandler();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
