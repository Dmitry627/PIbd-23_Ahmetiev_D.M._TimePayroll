using TimePayroll.Entities;

namespace TimePayroll.Repositories;

public interface IWorkEntryRepository
{
    IEnumerable<WorkEntry> ReadWorkEntries();

    void CreateWorkEntry(WorkEntry entry);

    void DeleteWorkEntry(WorkEntry entry);
}