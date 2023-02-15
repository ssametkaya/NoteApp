using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using NoteAppAPI.Context;
using NoteAppAPI.Service.Abstract;
using NoteAppAPI.Service.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<NoteAppContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<INoteService, NoteService>();
builder.Services.AddScoped<ISubNoteService, SubNoteService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(a => {
    a.AllowAnyOrigin();
    a.AllowAnyMethod();
    a.AllowAnyHeader();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
