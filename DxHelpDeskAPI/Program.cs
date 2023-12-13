using DxHelpDeskAPI.Application.Interfaces;
using DxHelpDeskAPI.Domain.Interfaces;
using DxHelpDeskAPI.Extensions;
using DxHelpDeskAPI.Persistence.Repositories;
using DxHelpDeskAPI.Application.Services;

using System.Reflection;
using DxHelpDeskAPI.Application.Mappings.Profiles;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAutoMapper(typeof(MappingProfile));
// Get the assemblies where services and repositories are located
Assembly[] targetAssemblies = { Assembly.GetExecutingAssembly() }; // Add other assemblies if needed

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
