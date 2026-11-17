using TimePayroll.Entities;
using TimePayroll.Repositories;

namespace TimePayroll.Repositories.Implementations;

// Заглушка репозитория надбавок работников
public class EmployeeBonusRepository : IEmployeeBonusRepository
{
    // Заглушка получения списка надбавок работников, пока выбрасывает исключение
    public IEnumerable<EmployeeBonus> ReadEmployeeBonuses()
    {
        throw new NotImplementedException();
    }

    // Заглушка создания надбавки работника, пока выбрасывает исключение
    public void CreateEmployeeBonus(EmployeeBonus bonus)
    {
        throw new NotImplementedException();
    }

    // Заглушка удаления надбавки работника, пока выбрасывает исключение
    public void DeleteEmployeeBonus(EmployeeBonus bonus)
    {
        throw new NotImplementedException();
    }
}
