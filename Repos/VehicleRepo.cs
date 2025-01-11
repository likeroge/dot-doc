using AtcAntarctic.Data;
using AtcAntarctic.Models;
using AtcAntarctic.Models.Dto;
using AtcAntarctic.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AtcAntarctic.Repos;

public class VehicleRepo : ICrud<Vehicle>
{
    private readonly AppDbContext _context;

    public VehicleRepo(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Vehicle>> GetAll()
    {
      return  await _context.Vehicles.ToListAsync();
       // return _context.Vehicles.ToList();
    }

    public Vehicle? Get(long id)
    {
        return _context.Vehicles.Find(id);
    }

    public Vehicle? Delete(long id)
    {
        var vehicle = _context.Vehicles.Find(id);
        if (vehicle == null) return null;
        _context.Vehicles.Remove(vehicle);
        _context.SaveChanges();
        return vehicle;
    }

    public async Task<Vehicle?> Create(CreateVehicleDto dto) {
        var vehicle = new Vehicle
        {
            Name = dto.Name,
            Type = dto.Type
        };
        await _context.Vehicles.AddAsync(vehicle);
        await _context.SaveChangesAsync();
        return vehicle;
    }

    public IEnumerable<VehicleType> GetVehicleTypes()
    {
        return Enum.GetValues<VehicleType>().ToList();
    }
}