using AtcAntarctic.Models;
using Microsoft.EntityFrameworkCore;

namespace AtcAntarctic.Data;

public class AppDbContext : DbContext
{
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Place> Places { get; set; }
    public DbSet<TransportNote> TransportNotes { get; set; }
    
    public AppDbContext( DbContextOptions<AppDbContext> options) : base(options){}
    
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<TransportNote>()
    //         .HasOne(tn => tn.From)
    //         .WithMany()
    //         .HasForeignKey(t=> t.FromId);
    //     
    //     modelBuilder.Entity<TransportNote>()
    //         .HasOne(tn => tn.To)
    //         .WithMany()
    //         .HasForeignKey(tn => tn.ToId);
    // }
}