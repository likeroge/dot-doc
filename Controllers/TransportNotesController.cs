using AtcAntarctic.Models;
using AtcAntarctic.Models.Dto;
using AtcAntarctic.Repos;
using Microsoft.AspNetCore.Mvc;

namespace AtcAntarctic.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransportNotesController : ControllerBase
{
    private readonly TransportNotesRepo _repo;
    private readonly ILogger<TransportNotesController> _logger;

    public TransportNotesController(TransportNotesRepo repo, ILogger<TransportNotesController> logger)
    {
        _repo = repo;
        _logger = logger;
    }
    
    [HttpGet]
    public IEnumerable<TransportNote> GetAll()
    {
        return _repo.GetAll();
    }
    
    [HttpGet("{id:int}")]
    public TransportNote? Get(int id)
    {
        return _repo.Get(id);
    }
    
    [HttpPost]
    public IActionResult Create(CreateTransportNoteDto dto)
    {
        try
        {
            var transportNote =  _repo.Create(dto);
            return Ok(transportNote);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        try
        {
            var transportNote = _repo.Delete(id);
            return Ok(transportNote);
        }
        catch (Exception e)
        {
          return BadRequest(e.Message);
        }
    }
}