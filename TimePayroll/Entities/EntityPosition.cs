namespace TimePayroll.Entities;

// Модель должности
public class Position
{
    // Хранит уникальный идентификатор записи
    public int Id { get; private set; }

    // Хранит название должности или проекта
    public string Name { get; private set; } = string.Empty;

    // Хранит почасовую ставку должности
    public decimal HourlyRate { get; private set; }

    // Создает объект должности из переданных значений
    public static Position CreateEntity(int id, string? name, decimal hourlyRate)
    {
        return new Position
        {
            Id = id,
            Name = name ?? string.Empty,
            HourlyRate = hourlyRate
        };
    }
}
