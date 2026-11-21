namespace TimePayroll.Entities;

// Модель начисления зарплаты
public class Payroll
{
    // Хранит уникальный идентификатор записи
    public long Id { get; private set; }

    // Хранит идентификатор работника
    public long EmployeeId { get; private set; }

    // Хранит месяц начисления зарплаты
    public DateTime PeriodMonth { get; private set; }

    // Хранит общее количество отработанных часов
    public decimal TotalHours { get; private set; }

    // Хранит основную часть зарплаты
    public decimal BaseSalary { get; private set; }

    // Хранит сумму надбавок
    public decimal BonusAmount { get; private set; }

    // Хранит итоговую сумму зарплаты
    public decimal TotalSalary { get; private set; }

    // Создает объект начисления зарплаты из переданных значений
    public static Payroll CreateEntity(
        long id,
        long employeeId,
        DateTime periodMonth,
        decimal totalHours,
        decimal baseSalary,
        decimal bonusAmount,
        decimal totalSalary)
    {
        return new Payroll
        {
            Id = id,
            EmployeeId = employeeId,
            PeriodMonth = periodMonth,
            TotalHours = totalHours,
            BaseSalary = baseSalary,
            BonusAmount = bonusAmount,
            TotalSalary = totalSalary
        };
    }
}
