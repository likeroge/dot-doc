using System.ComponentModel.DataAnnotations;

namespace AtcAntarctic.Models.Dto;

public record CreatePlaceDto(
    [Required]
    string Name,
    string? Description
    );