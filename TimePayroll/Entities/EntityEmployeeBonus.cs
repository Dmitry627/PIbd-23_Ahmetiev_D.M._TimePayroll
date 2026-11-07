namespace TimePayroll.Entities;

public class EmployeeBonus
{
    public long Id { get; private set; }

    public long EmployeeId { get; private set; }

    public int BonusType { get; private set; }

    public DateTime StartDate { get; private set; }

    public DateTime EndDate { get; private set; }

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
