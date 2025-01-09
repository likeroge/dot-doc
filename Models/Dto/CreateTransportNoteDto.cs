namespace AtcAntarctic.Models.Dto;

public record CreateTransportNoteDto (
        int FromId,
        int ToId,
        int  VehicleId,
        DateTime Atd,
        DateTime Ata,
        DateTime Date,
        string Rmk
    );