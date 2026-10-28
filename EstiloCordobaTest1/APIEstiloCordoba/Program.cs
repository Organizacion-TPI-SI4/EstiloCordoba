using EstiloCordobaEF;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<EstiloCordobaDatos.EstiloCordobaDatos>();
builder.Services.AddScoped<EstiloCordobaNegocio.EstiloCordobaNegocio>();

// Registrar servicios
builder.Services.AddControllers();

builder.Services.AddDbContext<EstiloCordobaDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddOpenApi();

var app = builder.Build();

// Configurar el pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();