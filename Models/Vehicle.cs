using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AtcAntarctic.Models.Abstract;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace AtcAntarctic.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VehicleType { Car, RwyService }

public class Vehicle : BaseModel
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    
    public VehicleType Type { get; set; }
}