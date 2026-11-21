using TimePayroll.Entities;
using TimePayroll.Repositories;

namespace TimePayroll.Repositories.Implementations;

// Заглушка репозитория записей рабочего времени
public class WorkEntryRepository : IWorkEntryRepository
{
    // Возвращает пустой список записей рабочего времени для заглушки
    public IEnumerable<WorkEntry> ReadWorkEntries()
    {
        return [];
    }
    
    // Заглушка создания записи рабочего времени без сохранения данных
    public void CreateWorkEntry(WorkEntry entry)
    {
    }

    // Заглушка удаления записи рабочего времени, пока выбрасывает исключение
    public void DeleteWorkEntry(WorkEntry entry)
    {
        throw new NotImplementedException();
    }
}
