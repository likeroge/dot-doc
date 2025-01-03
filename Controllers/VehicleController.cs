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
    public IEnumerable<Vehicle> Get()
    {
        var testValue = _configuration.GetSection("Test").Value;
        _logger.LogInformation(testValue);
        
        return _repo.GetAll();
    }
    
    [HttpGet("{id:int}")]
    public Vehicle? Get(int id)
    {
        return _repo.Get(id);
    }
    
    [HttpPost]
    public Vehicle? Create(CreateVehicleDto dto)
    {
        return _repo.Create(dto);
    }
    
    [HttpDelete]
    public Vehicle? Delete(Vehicle entity)
    {
        return _repo.Delete(entity);
    }
}