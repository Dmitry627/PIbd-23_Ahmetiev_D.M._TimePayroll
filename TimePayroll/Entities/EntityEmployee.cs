namespace TimePayroll.Entities;

public class Employee
{
    public long Id { get; private set; }

    public string FirstName { get; private set; } = string.Empty;

    public string SecondName { get; private set; } = string.Empty;

    public int PositionId { get; private set; }

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
