using AtcAntarctic.Data;
using AtcAntarctic.Models;
using AtcAntarctic.Models.Dto;
using AtcAntarctic.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AtcAntarctic.Repos;

public class TransportNotesRepo : ICrud<TransportNote>
{
    private readonly AppDbContext _context;

    public TransportNotesRepo(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TransportNote>> GetAll()
    {
        return await _context.TransportNotes
            .Include(tn=>tn.Vehicle)
            .Include(tn=>tn.From)
            .Include(tn=>tn.To)
            .ToListAsync();
        // return _context.TransportNotes.ToList();
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
    
    /// <summary>
    /// Update a transport note with the given <paramref name="dto"/>.
    /// </summary>
    /// <param name="dto">The updated transport note data.</param>
    /// <returns>The updated transport note.</returns>
    /// <exception cref="Exception">If the transport note does not exist.</exception>
    public TransportNote? Update(UpdateTransportNoteDto dto)
    {
        var transportNote = _context.TransportNotes.Find(dto.Id);
        if (transportNote==null)
        {
            throw new Exception("TransportNote not exist");
        }
        transportNote.FromId = dto.FromId ?? transportNote.FromId;
        transportNote.ToId = dto.ToId ?? transportNote.ToId ;
        transportNote.VehicleId = dto.VehicleId?? transportNote.VehicleId;
        transportNote.Atd = dto.Atd ?? transportNote.Atd;
        transportNote.Ata = dto.Ata ?? transportNote.Ata;
        transportNote.Rmk = dto.Rmk ?? transportNote.Rmk;
        transportNote.Date = dto.Date ?? transportNote.Date;
        transportNote.Pob = dto.Pob ?? transportNote.Pob;
        _context.TransportNotes.Update(transportNote);
        _context.SaveChanges();
        return transportNote;
    }
}