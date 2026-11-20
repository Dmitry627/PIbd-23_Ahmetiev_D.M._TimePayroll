using TimePayroll.Entities;
using TimePayroll.Repositories;

namespace TimePayroll.Repositories.Implementations;

// Заглушка репозитория проектов
public class ProjectRepository : IProjectRepository
{
    // Возвращает пустой список проектов для заглушки
    public IEnumerable<Project> ReadProjects()
    {
        return [];
    }
    
    // Заглушка получения проекта по идентификатору, пока выбрасывает исключение
    public Project ReadProjectById(long id)
    {
        throw new NotImplementedException();
    }

    // Заглушка создания проекта, пока выбрасывает исключение
    public void CreateProject(Project project)
    {
        throw new NotImplementedException();
    }

    // Заглушка изменения проекта, пока выбрасывает исключение
    public void UpdateProject(Project project)
    {
        throw new NotImplementedException();
    }

    // Заглушка удаления проекта, пока выбрасывает исключение
    public void DeleteProject(Project project)
    {
        throw new NotImplementedException();
    }
}
