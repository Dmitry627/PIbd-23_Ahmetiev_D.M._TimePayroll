namespace TimePayroll.Entities;

public class Project
{
    public long Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public int Type { get; private set; }

    public long ManagerId { get; private set; }

    public long DeveloperId { get; private set; }

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
