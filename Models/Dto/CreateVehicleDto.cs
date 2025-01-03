using System.ComponentModel.DataAnnotations;

namespace AtcAntarctic.Models.Dto;

public class CreateVehicleDto
{
    [Required]
    public string Name { get; set; }
    [Required]
    public VehicleType Type { get; set; }
    
}