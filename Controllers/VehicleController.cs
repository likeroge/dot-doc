using AtcAntarctic.Models;
using AtcAntarctic.Models.Dto;
using AtcAntarctic.Repos;
using Microsoft.AspNetCore.Mvc;

namespace AtcAntarctic.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehicleController
{
    private readonly ILogger<VehicleController> _logger;
    private readonly VehicleRepo _repo;
    private readonly IConfiguration _configuration;
    public VehicleController(ILogger<VehicleController> logger, VehicleRepo repo, IConfiguration configuration)
    {
        _logger = logger;
        _repo = repo;
        _configuration = configuration;
    }
    
    [HttpGet]
    public async Task<IEnumerable<Vehicle>> Get()
    {
        var testValue = _configuration.GetSection("Test").Value;
        _logger.LogInformation(testValue);
        
        return await _repo.GetAll();
    }
    
    [HttpGet("{id:int}")]
    public Vehicle? Get(int id)
    {
        return _repo.Get(id);
    }
    
    [HttpPost]
    public async Task<Vehicle?> Create(CreateVehicleDto dto)
    {
        Console.WriteLine($"This is request body {dto}");
        return await _repo.Create(dto);
    }
    
    [HttpDelete("{id:int}")]
    public Vehicle? Delete(int id)
    {
        Console.WriteLine($"This is request body {id}");
        return _repo.Delete(id);
    }
    
    [HttpGet("vehicleTypes")]
    public IEnumerable<VehicleType> GetVehicleTypes()
    {
        return _repo.GetVehicleTypes();
    }
}