using TimePayroll.Entities;
using TimePayroll.Repositories;

namespace TimePayroll.Repositories.Implementations;

public class WorkEntryRepository : IWorkEntryRepository
{
    public IEnumerable<WorkEntry> ReadWorkEntries()
    {
        throw new NotImplementedException();
    }
    
    public void CreateWorkEntry(WorkEntry entry)
    {
        throw new NotImplementedException();
    }

    public void DeleteWorkEntry(WorkEntry entry)
    {
        throw new NotImplementedException();
    }
}
