
using EaseeRisk;
using EaseeRisk.Model;
using EaseeRisk.Repository;
using EaseeRisk.Requests;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var options = SurrealDbOptions
    .Create()
    .WithEndpoint("http://127.0.0.1:8080")
    .WithNamespace("easeerisk")
    .WithDatabase("easeerisk")
    .Build();

builder.Services.AddSurreal(options);


// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

builder.Services.AddSingleton<IRelationshipRepository, RelationshipRepository>();
builder.Services.AddSingleton<IRelationshipBuilder, RelationshipBuilder>();
builder.Services.AddRepository<RiskAssessmentTemplate, CreateRiskAssessmentTemplate>();
builder.Services.AddRepository<RiskIndicatorGroup, CreateRiskIndicatorGroup>();

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
