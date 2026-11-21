using TimePayroll.Entities;
using TimePayroll.Repositories;

namespace TimePayroll.Repositories.Implementations;

// Заглушка репозитория надбавок работников
public class EmployeeBonusRepository : IEmployeeBonusRepository
{
    // Возвращает пустой список надбавок работников для заглушки
    public IEnumerable<EmployeeBonus> ReadEmployeeBonuses()
    {
        return [];
    }

    // Заглушка создания надбавки работника без сохранения данных
    public void CreateEmployeeBonus(EmployeeBonus bonus)
    {
    }

    // Заглушка удаления надбавки работника без изменения данных
    public void DeleteEmployeeBonus(EmployeeBonus bonus)
    {
    }
}
