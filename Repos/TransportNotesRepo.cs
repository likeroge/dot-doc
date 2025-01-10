using AtcAntarctic.Data;
using AtcAntarctic.Models;
using AtcAntarctic.Models.Dto;
using AtcAntarctic.Repos.Interfaces;

namespace AtcAntarctic.Repos;

public class TransportNotesRepo : ICrud<TransportNote>
{
    private readonly AppDbContext _context;

    public TransportNotesRepo(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<TransportNote> GetAll()
    {
        return _context.TransportNotes.ToList();
    }

    public TransportNote? Get(long id)
    {
        return _context.TransportNotes.Find(id);
    }

    public TransportNote? Delete(long sid)
    {
        var transportNote = _context.TransportNotes.Find(sid);
        if (transportNote==null)
        {
            throw new Exception("TransportNote not exist");
        }
        return _context.TransportNotes.Remove(transportNote).Entity;
    }

    public TransportNote? Create(CreateTransportNoteDto dto)
    {
        var isVehicleExist  = _context.Vehicles.Any(v => v.Id == dto.VehicleId);
        var isFromExist = _context.Places.Any(p => p.Id == dto.FromId);
        var isToExist = _context.Places.Any(p => p.Id == dto.ToId);
        if (!isVehicleExist || !isFromExist || !isToExist)
        {
            throw new Exception("Vehicle or Place not exist");
        }
        var transportNote = new TransportNote
        {
            FromId = dto.FromId,
            ToId = dto.ToId,
            VehicleId = dto.VehicleId,
            Atd = dto.Atd,
            Ata = dto.Ata,
            Rmk = dto.Rmk,
            Date = dto.Date,
            Pob = dto.Pob
        };
        _context.TransportNotes.Add(transportNote);
        _context.SaveChanges();
        return transportNote;
    }
}