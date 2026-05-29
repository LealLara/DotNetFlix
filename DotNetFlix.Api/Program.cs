using DotNetFlix.Application.Interfaces.IRepository;
using DotNetFlix.Application.Interfaces.Services;
using DotNetFlix.Application.Services;
using DotNetFlix.Infrastructure.Data.Context;
using DotNetFlix.Infrastructure.Repositories;
using DotNetFlix.Infrastructure.Security;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlite("Data Source=dotnetflix.db"));


builder.Services.AddScoped<IMovieService, MovieService>();

builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddScoped<IJwtProvider, JwtProvider>();



builder.Services.AddScoped<ILogRepository, LogRepository>();
builder.Services.AddScoped<ILogTypeRepository, LogTypeRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

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