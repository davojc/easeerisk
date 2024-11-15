
using EaseeRisk.Store;

var builder = WebApplication.CreateBuilder(args);

var options = SurrealDbOptions
    .Create()
    .WithEndpoint("http://127.0.0.1:8080")
    .WithNamespace("easeerisk")
    .WithDatabase("easeerisk")
    .Build();



builder.Services.AddSurreal(options);
builder.Services.AddSingleton<IRiskAssessmentStore, SurrealDbStore>();


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

app.UseAuthorization();

app.MapControllers();

app.Run();
