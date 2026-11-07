namespace TimePayroll.Entities;

public class WorkEntry
{
    public long Id { get; private set; }

    public long EmployeeId { get; private set; }

    public long ProjectId { get; private set; }

    public int WorkType { get; private set; }

    public DateTime WorkDate { get; private set; }

    public decimal Hours { get; private set; }

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
