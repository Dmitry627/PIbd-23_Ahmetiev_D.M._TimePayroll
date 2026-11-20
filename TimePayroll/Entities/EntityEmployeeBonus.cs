namespace TimePayroll.Entities;

// Модель надбавки работника
public class EmployeeBonus
{
    // Хранит уникальный идентификатор записи
    public long Id { get; private set; }

    // Хранит идентификатор работника
    public long EmployeeId { get; private set; }

    // Хранит вид надбавки
    public int BonusType { get; private set; }

    // Хранит дату начала действия надбавки
    public DateTime StartDate { get; private set; }

    // Хранит дату окончания действия надбавки
    public DateTime EndDate { get; private set; }

    // Создает объект надбавки работника из переданных значений
    public static EmployeeBonus CreateEntity(
        long id,
        long employeeId,
        int bonusType,
        DateTime startDate,
        DateTime endDate)
    {
        return new EmployeeBonus
        {
            Id = id,
            EmployeeId = employeeId,
            BonusType = bonusType,
            StartDate = startDate,
            EndDate = endDate
        };
    }
}
