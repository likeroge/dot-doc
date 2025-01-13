using System.Reflection;
using AtcAntarctic.Data;
using AtcAntarctic.Models;
using AtcAntarctic.Repos;

namespace AtcAntarctic.Services;

public class TransportNotesService
{
    private readonly TransportNotesRepo _transportNotesRepo;
    private readonly ILogger<TransportNotesService> _logger;
    private readonly AppDbContext _context;

    public TransportNotesService(TransportNotesRepo transportNotesRepo, ILogger<TransportNotesService> logger, AppDbContext context)
    {
        _transportNotesRepo = transportNotesRepo;
        _logger = logger;
        _context = context;
    }
}