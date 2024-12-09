
using EaseeRisk;
using EaseeRisk.Model.Assessments;
using EaseeRisk.Model.Templates;
using EaseeRisk.Repository;
using EaseeRisk.Requests;
using System.Text.Json.Serialization;
using Indicator = EaseeRisk.Model.Templates.Indicator;
using IndicatorGroup = EaseeRisk.Model.Templates.IndicatorGroup;

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

//builder.Services.AddJsonOptions()

builder.Services.AddSingleton<IRelationshipRepository, RelationshipRepository>();
builder.Services.AddSingleton<IRelationshipBuilder, RelationshipBuilder>();
builder.Services.AddRepository<Template, CreateRiskAssessmentTemplateRequest>();
builder.Services.AddRepository<IndicatorGroup, CreateRiskIndicatorGroupRequest>();
builder.Services.AddRepository<Indicator, CreateRiskIndicatorRequest>();
builder.Services.AddRepository<RiskLevelSet, CreateRiskLevelSetRequest>();
builder.Services.AddRepository<RiskAssessment, CreateRiskAssesmentRequest>();

// Add services to the container.
builder.Services.AddControllers()
    .AddJsonOptions(jsonOptions =>
    {
        var enumConverter = new JsonStringEnumConverter();
        jsonOptions.JsonSerializerOptions.Converters.Add(enumConverter);
        jsonOptions.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOpenApi();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
