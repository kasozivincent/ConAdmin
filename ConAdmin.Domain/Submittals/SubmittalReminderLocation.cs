namespace ConAdmin.Domain.Submittals;

[Flags]
public enum SubmittalRemainderLocation
{
    None,
    RollDrawings,
    FilingCabinet,
    FilingCabinetUnderSubmittalNumber,
    Other
}