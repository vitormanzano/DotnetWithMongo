using Gerenciamento.Funcionarios.CrossCutting.Repositories;
using Gerenciamento.Funcionarios.CrossCutting.Validators;
using Gerenciamento.Funcionarios.CrossCutting.Services;
using Gerenciamento.Funcionarios.CrossCutting.Model;
using Gerenciamento.Funcionarios.CrossCutting.Mongo;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var applicationSettings = builder.Configuration.GetSection("Settings").Get<Settings>();

builder.Services.AddControllers();
builder.Services.AddRepositories();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddValidators();
builder.Services.AddServices();
builder.Services.AddMongo(applicationSettings!.MongoSettings!);

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
