using System.ComponentModel.DataAnnotations;
using AtcAntarctic.Models.Abstract;

namespace AtcAntarctic.Models;

public class TransportNote : BaseModel
{
    public long FromId { get; set; }
    public long ToId { get; set; }

    public Place? From { get; set; }
    public Place? To { get; set; }

    [Required]
    public long  VehicleId { get; set; }

    public Vehicle? Vehicle { get; set; }
    public DateTime? Atd { get; set; }
    public DateTime? Ata { get; set; }
    [MaxLength(500)]
    public string? Rmk { get; set; }
    public DateTime? Date { get; set; } = DateTime.Now;
    public short Pob { get; set; }
}