namespace TimePayroll.Entities;

public class Position
{
    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public decimal HourlyRate { get; private set; }

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
