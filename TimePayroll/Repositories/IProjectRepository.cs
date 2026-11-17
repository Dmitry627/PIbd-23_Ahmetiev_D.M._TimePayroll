using TimePayroll.Entities;

namespace TimePayroll.Repositories;

// Описывает доступные операции репозитория проектов
public interface IProjectRepository
{
    // Определяет метод получения списка проектов
    IEnumerable<Project> ReadProjects();

    // Определяет метод получения проекта по идентификатору
    Project ReadProjectById(long id);

    // Определяет метод создания проекта
    void CreateProject(Project project);

    // Определяет метод изменения проекта
    void UpdateProject(Project project);

    // Определяет метод удаления проекта
    void DeleteProject(Project project);
}