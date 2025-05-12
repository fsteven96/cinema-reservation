using CinemaReservation.Infrastructure;
using Microsoft.EntityFrameworkCore;
using CinemaReservation.Infrastructure.Repositories;
using CinemaReservation.Application.Interfaces;
using Microsoft.OpenApi.Models; // 👉 asegúrate de tener esto

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios de controladores
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// 👉 Agrega Swagger aquí:
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Cinema Reservation API",
        Version = "v1"
    });
});

// Registrar repositorios y DbContext
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddDbContext<CinemaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Crear la aplicación
var app = builder.Build();

// 👉 Usa Swagger en el middleware (solo en desarrollo si prefieres)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cinema API V1");
});

// Configurar el pipeline
app.UseRouting();
app.MapControllers();
app.Run();

