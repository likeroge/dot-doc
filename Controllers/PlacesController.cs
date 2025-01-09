using AtcAntarctic.Models;
using AtcAntarctic.Models.Dto;
using AtcAntarctic.Repos;
using Microsoft.AspNetCore.Mvc;

namespace AtcAntarctic.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlacesController
{
    private readonly ILogger<PlacesController> _logger;
    private readonly PlacesRepo _repo;

    public PlacesController(PlacesRepo repo, ILogger<PlacesController> logger)
    {
        _repo = repo;
        _logger = logger;
    }
    
    [HttpGet]
    public IEnumerable<Place> Get()
    {
        return _repo.GetAll();
    }
    
    [HttpGet("{id}")]
    public Place? Get(int id)
    {
        return _repo.Get(id);
    }
    
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _repo.Delete(id);
    }
    
    [HttpPost]
    public Place? Create(CreatePlaceDto dto)
    {
        return _repo.Create(dto);
    }
}