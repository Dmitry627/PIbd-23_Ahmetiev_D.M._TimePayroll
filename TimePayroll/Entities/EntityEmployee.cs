namespace TimePayroll.Entities;

// Модель работника
public class Employee
{
    // Хранит уникальный идентификатор записи
    public long Id { get; private set; }

    // Хранит имя работника
    public string FirstName { get; private set; } = string.Empty;

    // Хранит фамилию работника
    public string SecondName { get; private set; } = string.Empty;

    // Хранит идентификатор должности работника
    public int PositionId { get; private set; }

    // Создает объект работника из переданных значений
    public static Employee CreateEntity(long id, string? firstName, string? secondName, int positionId)
    {
        return new Employee
        {
            Id = id,
            FirstName = firstName ?? string.Empty,
            SecondName = secondName ?? string.Empty,
            PositionId = positionId
        };
    }
}
