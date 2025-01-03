using System.ComponentModel.DataAnnotations;

namespace AtcAntarctic.Models.Abstract;

public abstract class BaseModel
{
    [Key]
    public long Id { get; set; }
}