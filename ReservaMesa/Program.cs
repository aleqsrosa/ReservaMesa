using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Reserva.Application.AutoMapper;
using Reserva.Infra.Data.Context;
using Reserva.Infra.IoC;
using AutoMapper;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ReservaContext>(ServiceLifetime.Scoped);
NativeInjector.RegisterServices(builder.Services);
builder.Services.AddAutoMapper(typeof(AutoMapperSetup));

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
