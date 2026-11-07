namespace TimePayroll.Entities.Enums;

[Flags]
public enum BonusType
{
    None = 0,

    Experience = 1,

    Qualification = 2,
    
    Performance = 4,

    ProjectComplexity = 8
}
