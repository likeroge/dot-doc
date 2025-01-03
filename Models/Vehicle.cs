using System.ComponentModel.DataAnnotations;
using AtcAntarctic.Models.Abstract;

namespace AtcAntarctic.Models;

public enum VehicleType { Car, RwyService }

public class Vehicle : BaseModel
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    public VehicleType Type { get; set; }
}