
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PetHealth.Core.Entities;
using PetHealth.Infrastructure.Persistence.Contexts;
using PetHealth.WebUtilities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.ConfigureSwagger();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddAuthentication();

// Project specific.
builder.Services.AddCore();
builder.Services.AddInfrastructure(builder.Configuration);


// Personalized web utilities.
builder.Services.AddTransient<GlobalExceptionHandlingMiddleware>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// migrate any database changes on startup (includes initial db creation)
using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<PetHealthContext>();
    dataContext.Database.Migrate();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
app.MapControllers();

app.Run();
