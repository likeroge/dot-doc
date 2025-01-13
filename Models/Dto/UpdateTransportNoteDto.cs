namespace AtcAntarctic.Models.Dto;

public record UpdateTransportNoteDto(
    long Id,
    long? VehicleId,
    long? FromId,
    long? ToId,
    DateTime? Atd,
    DateTime? Ata,
    string? Rmk,
    DateTime? Date,
    short? Pob
);