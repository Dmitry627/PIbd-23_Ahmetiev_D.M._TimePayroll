using TimePayroll.Entities;
using TimePayroll.Repositories;

namespace TimePayroll.Repositories.Implementations;

// Заглушка репозитория записей рабочего времени
public class WorkEntryRepository : IWorkEntryRepository
{
    // Заглушка получения списка записей рабочего времени, пока выбрасывает исключение
    public IEnumerable<WorkEntry> ReadWorkEntries()
    {
        throw new NotImplementedException();
    }
    
    // Заглушка создания записи рабочего времени, пока выбрасывает исключение
    public void CreateWorkEntry(WorkEntry entry)
    {
        throw new NotImplementedException();
    }

    // Заглушка удаления записи рабочего времени, пока выбрасывает исключение
    public void DeleteWorkEntry(WorkEntry entry)
    {
        throw new NotImplementedException();
    }
}
