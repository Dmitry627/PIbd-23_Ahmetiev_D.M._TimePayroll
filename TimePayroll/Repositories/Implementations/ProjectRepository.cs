using TimePayroll.Entities;
using TimePayroll.Repositories;

namespace TimePayroll.Repositories.Implementations;

public class ProjectRepository : IProjectRepository
{
    public IEnumerable<Project> ReadProjects()
    {
        throw new NotImplementedException();
    }
    
    public Project ReadProjectById(long id)
    {
        throw new NotImplementedException();
    }

    public void CreateProject(Project project)
    {
        throw new NotImplementedException();
    }

    public void UpdateProject(Project project)
    {
        throw new NotImplementedException();
    }

    public void DeleteProject(Project project)
    {
        throw new NotImplementedException();
    }
}
