using AtcAntarctic.Data;
using AtcAntarctic.Models;
using AtcAntarctic.Models.Dto;
using AtcAntarctic.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AtcAntarctic.Repos;

public class PlacesRepo : ICrud<Place>
{
    
    private readonly AppDbContext _context;

    public PlacesRepo(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Place>> GetAll()
    {
       return await _context.Places.ToListAsync();
    }

    public Place? Get(long id)
    {
        return _context.Places.Find(id);
    }

    public Place? Delete(long id)
    {
        var place = _context.Places.Find(id);
        return place == null ? null : _context.Places.Remove(place).Entity;
    }
    
    public Place? Create(CreatePlaceDto dto)
    {
        var place = new Place
        {
            Name = dto.Name,
            Description = dto.Description ?? string.Empty
        };
         _context.Places.Add(place);
        _context.SaveChanges();
        return place;
    }
}