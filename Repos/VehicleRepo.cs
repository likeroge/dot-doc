using AtcAntarctic.Data;
using AtcAntarctic.Models;
using AtcAntarctic.Models.Dto;
using AtcAntarctic.Repos.Interfaces;

namespace AtcAntarctic.Repos;

public class VehicleRepo : ICrud<Vehicle>
{
    private readonly AppDbContext _context;

    public VehicleRepo(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Vehicle> GetAll()
    {
       return _context.Vehicles.ToList();
    }

    public Vehicle? Get(int id)
    {
        return _context.Vehicles.Find(id);
    }

    public Vehicle? Delete(int id)
    {
        var vehicle = _context.Vehicles.Find(id);
        if (vehicle == null) return null;
        _context.Vehicles.Remove(vehicle);
        _context.SaveChanges();
        return vehicle;
    }

    public Vehicle? Create(CreateVehicleDto dto) {
        var vehicle = new Vehicle
        {
            Name = dto.Name,
            Type = dto.Type
        };
        _context.Vehicles.Add(vehicle);
        _context.SaveChanges();
        return vehicle;
    }
}