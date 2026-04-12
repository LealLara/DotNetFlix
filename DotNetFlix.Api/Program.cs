using DotNetFlix.Application.Services;
using DotNetFlix.Domain.Interfaces.IRepository;
using DotNetFlix.Domain.Interfaces.IServices;
using DotNetFlix.Infrastructure.Data;
using DotNetFlix.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
 
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlite("Data Source=dotnetflix.db"));

builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();