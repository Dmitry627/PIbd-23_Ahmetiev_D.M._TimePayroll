namespace TimePayroll.Entities;

public class Payroll
{
    public long Id { get; private set; }

    public long EmployeeId { get; private set; }

    public DateTime PeriodMonth { get; private set; }

    public decimal TotalHours { get; private set; }

    public decimal BaseSalary { get; private set; }

    public decimal BonusAmount { get; private set; }

    public decimal TotalSalary { get; private set; }

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
