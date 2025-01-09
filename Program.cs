using System.Net;
using AtcAntarctic.Data;
using AtcAntarctic.Repos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configurationSection = builder.Configuration["Test"];
Console.WriteLine(configurationSection);

//Http client
builder.Services
    .AddHttpClient("MyApiClient", client => client
        .BaseAddress = new Uri(builder.Configuration["BaseUrl"]));

builder.Services.AddDbContext<AppDbContext>(options => options
    .UseSqlite("Data Source=AtcAntarctic.db"));

builder.Services.AddScoped<VehicleRepo>();
builder.Services.AddScoped<PlacesRepo>();
builder.Services.AddScoped<TransportNotesRepo>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.MapRazorPages();

app.Run();