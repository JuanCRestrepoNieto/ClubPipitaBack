using Data;
using Data.Repositorio;
using Microsoft.EntityFrameworkCore;
using Services;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins, policy =>
    {
        policy.WithOrigins("http://localhost:3000")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CLUBPIPITAContext>(options =>{
    options.UseSqlServer("name=ConexionBaseDeDatos");
});

builder.Services.AddScoped<RepositorioUsuario>();
builder.Services.AddScoped<RepositorioPersona>();
builder.Services.AddScoped<RepositorioEquipo>();
builder.Services.AddScoped<RepositorioRol>();
builder.Services.AddScoped<RepositorioJugador>();

builder.Services.AddScoped<ServiceUsuario>();
builder.Services.AddScoped<ServicePersona>();
builder.Services.AddScoped<ServiceRol>();
builder.Services.AddScoped<ServicioEquipo>();
builder.Services.AddScoped<ServiceJugador>();

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);

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
