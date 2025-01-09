using System.ComponentModel.DataAnnotations;
using AtcAntarctic.Models.Abstract;

namespace AtcAntarctic.Models;

public class Place :BaseModel
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [MaxLength(200)]
    public string? Description { get; set; }
}