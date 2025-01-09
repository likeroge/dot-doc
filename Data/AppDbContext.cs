using AtcAntarctic.Models;
using Microsoft.EntityFrameworkCore;

namespace AtcAntarctic.Data;

public class AppDbContext : DbContext
{
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Place> Places { get; set; }
    public DbSet<TransportNote> TransportNotes { get; set; }
    
    public AppDbContext( DbContextOptions<AppDbContext> options) : base(options){}
}