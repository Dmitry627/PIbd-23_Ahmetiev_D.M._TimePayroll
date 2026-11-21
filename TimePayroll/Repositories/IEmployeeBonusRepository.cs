using TimePayroll.Entities;

namespace TimePayroll.Repositories;

// Описывает доступные операции репозитория надбавок работников
public interface IEmployeeBonusRepository
{
    // Определяет метод получения списка надбавок работников
    IEnumerable<EmployeeBonus> ReadEmployeeBonuses();

    // Определяет метод создания надбавки работника
    void CreateEmployeeBonus(EmployeeBonus bonus);

    // Определяет метод удаления надбавки работника
    void DeleteEmployeeBonus(EmployeeBonus bonus);
}