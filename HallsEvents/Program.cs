//using EventsHalls.Entities;
using HallsEvents.Mapping;
using Solid.Core.Repositories;
using Solid.Core.Services;
using Solid.CoreM;
using Solid.Data;
using Solid.Data.Repositories;
using Solid.Service;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEventRepository, EventsRepository>();
builder.Services.AddScoped<IHallsRepository, HallsRepository>();
builder.Services.AddScoped<IInvitedRepository, InvitedRepository>();
builder.Services.AddScoped<IEventService, EventsService>();
builder.Services.AddScoped<IHallsService, HallsService>();
builder.Services.AddScoped<IInvitedService, InvitedService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddAutoMapper(typeof(PostModelMapping));



builder.Services.AddDbContext<DataContext>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
