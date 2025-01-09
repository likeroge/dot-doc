using System.ComponentModel.DataAnnotations;
using AtcAntarctic.Models.Abstract;

namespace AtcAntarctic.Models;

public class TransportNote : BaseModel
{
    public int FromId { get; set; }
    public int ToId { get; set; }
    [Required]
    public int  VehicleId { get; set; }
    public DateTime? Atd { get; set; }
    public DateTime? Ata { get; set; }
    public string? Rmk { get; set; }
    public DateTime? Date { get; set; } = DateTime.Now;
    
    public short Pob { get; set; }
}