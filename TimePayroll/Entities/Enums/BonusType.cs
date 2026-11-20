namespace TimePayroll.Entities.Enums;

[Flags]
// Виды надбавок, которые можно сочетать с помощью флагов
public enum BonusType
{
    // Обозначает отсутствие надбавок
    None = 0,

    // Обозначает надбавку за стаж
    Experience = 1,

    // Обозначает надбавку за квалификацию
    Qualification = 2,
    
    // Обозначает надбавку за результативность
    Performance = 4,

    // Обозначает надбавку за сложность проекта
    ProjectComplexity = 8
}
