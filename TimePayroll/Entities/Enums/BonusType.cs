namespace TimePayroll.Entities.Enums;

[Flags]
// Виды надбавок, которые можно сочетать с помощью флагов
public enum BonusType
{
    None = 0,

    Experience = 1,

    Qualification = 2,
    
    Performance = 4,

    ProjectComplexity = 8
}
