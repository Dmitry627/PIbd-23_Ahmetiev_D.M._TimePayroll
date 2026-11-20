namespace TimePayroll.Entities;

// Модель записи рабочего времени
public class WorkEntry
{
    // Хранит уникальный идентификатор записи
    public long Id { get; private set; }

    // Хранит идентификатор работника
    public long EmployeeId { get; private set; }

    // Хранит идентификатор проекта
    public long ProjectId { get; private set; }

    // Хранит вид выполненной работы
    public int WorkType { get; private set; }

    // Хранит дату выполнения работы
    public DateTime WorkDate { get; private set; }

    // Хранит количество часов работы
    public decimal Hours { get; private set; }

    // Создает объект записи рабочего времени из переданных значений
    public static WorkEntry CreateEntity(
        long id,
        long employeeId,
        long projectId,
        int workType,
        DateTime workDate,
        decimal hours)
    {
        return new WorkEntry
        {
            Id = id,
            EmployeeId = employeeId,
            ProjectId = projectId,
            WorkType = workType,
            WorkDate = workDate,
            Hours = hours
        };
    }
}
