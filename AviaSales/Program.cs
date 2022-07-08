using Microsoft.OpenApi.Models;
using API;
using Services;
using Entities;
using Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IPassengerMapper, PassengerMapper>();
builder.Services.AddTransient<IPassengerService, PassengerService>();
builder.Services.AddSingleton<IPassportMapper, PassportMapper>();
builder.Services.AddTransient<IPassportService, PassportService>();
builder.Services.AddSingleton<ICarrierMapper, CarrierMapper>();
builder.Services.AddTransient<ICarrierService, CarrierService>();
builder.Services.AddSingleton<IFlightMapper, FlightMapper>();
builder.Services.AddTransient<IFlightService, FlightService>();
builder.Services.AddSingleton<IBookingMapper, BookingMapper>();
builder.Services.AddTransient<IBookingService, BookingService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "AviaSales API",
    });

    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "AviaSales.xml"));
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "API.xml"));
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "DB.xml"));
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Entities.xml"));
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Middleware.xml"));
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Services.xml"));
});






builder.Services.ConfigureDbConnection();
//builder.Services.ConfigureDbConnection(builder.Configuration);

var app = builder.Build();

//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandlerMiddleware();

//app.UseAuthorization();

app.MapControllers();

app.Run();
