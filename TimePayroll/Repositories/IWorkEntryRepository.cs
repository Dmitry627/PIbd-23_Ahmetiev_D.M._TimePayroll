using TimePayroll.Entities;

namespace TimePayroll.Repositories;

// Описывает доступные операции репозитория записей рабочего времени
public interface IWorkEntryRepository
{
    // Определяет метод получения списка записей рабочего времени
    IEnumerable<WorkEntry> ReadWorkEntries();

    // Определяет метод создания записи рабочего времени
    void CreateWorkEntry(WorkEntry entry);

    // Определяет метод удаления записи рабочего времени
    void DeleteWorkEntry(WorkEntry entry);
}