using TimePayroll.Entities;

namespace TimePayroll.Repositories;

public interface IProjectRepository
{
    IEnumerable<Project> ReadProjects();

    Project ReadProjectById(long id);

    void CreateProject(Project project);

    void UpdateProject(Project project);

    void DeleteProject(Project project);
}