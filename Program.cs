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

IConfiguration configuration = new ConfigurationManager();
var configurationSection = configuration.GetSection("Test").Value;

//Http client
builder.Services
    .AddHttpClient("MyApiClient",client=> client
        .BaseAddress = new Uri(configuration.GetSection("BaseUrl").Value));

builder.Services.AddDbContext<AppDbContext>(options => options
    .UseSqlite("Data Source=AtcAntarctic.db"));

builder.Services.AddScoped<VehicleRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseHttpsRedirection();

app.MapControllers();

app.MapRazorPages();

app.Run();