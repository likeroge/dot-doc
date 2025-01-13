using AtcAntarctic.Models;
using AtcAntarctic.Models.Dto;
using AtcAntarctic.Repos;
using Microsoft.AspNetCore.Mvc;

namespace AtcAntarctic.Controllers;

[ApiController]
// [Route("api/[controller]")]
[Route("api/transport-notes")]
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
    public async Task<IEnumerable<TransportNote>> GetAll()
    {
        return await _repo.GetAll();
    }
    
    /// <summary>
    /// Get the transport note with the given <paramref name="id"/>.
    /// </summary>
    /// <param name="id">The ID of the transport note to get.</param>
    /// <returns>The transport note.</returns>
    [HttpGet("{id:int}")]
    public TransportNote? Get(int id)
    {
        return _repo.Get(id);
    }
    
    /// <summary>
    /// Create a new transport note.
    /// </summary>
    /// <param name="dto">The transport note data.</param>
    /// <returns>The created transport note.</returns>
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

    /// <summary>
    /// Delete the transport note with the given <paramref name="id"/>.
    /// </summary>
    /// <param name="id">The ID of the transport note to delete.</param>
    /// <returns>The deleted transport note.</returns>
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
    
    /// <summary>
    /// Update a transport note with the given <paramref name="id"/>.
    /// </summary>
    /// <param name="id">The ID of the transport note to update.</param>
    /// <param name="dto">The updated transport note data.</param>
    /// <returns>The updated transport note.</returns>
    [HttpPatch("{id:int}")]
    public IActionResult Update(int id, UpdateTransportNoteDto dto)
    {
        try
        {
            var transportNote = _repo.Update(dto);
            return Ok(transportNote);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    
}