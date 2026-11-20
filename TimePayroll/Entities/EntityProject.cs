namespace TimePayroll.Entities;

// Модель проекта
public class Project
{
    // Хранит уникальный идентификатор записи
    public long Id { get; private set; }

    // Хранит название должности или проекта
    public string Name { get; private set; } = string.Empty;

    // Хранит тип проекта
    public int Type { get; private set; }

    // Хранит идентификатор менеджера проекта
    public long ManagerId { get; private set; }

    // Хранит идентификатор разработчика проекта
    public long DeveloperId { get; private set; }

    // Создает объект проекта из переданных значений
    public static Project CreateEntity(long id, string? name, int type, long managerId, long developerId)
    {
        return new Project
        {
            Id = id,
            Name = name ?? string.Empty,
            Type = type,
            ManagerId = managerId,
            DeveloperId = developerId
        };
    }
}
