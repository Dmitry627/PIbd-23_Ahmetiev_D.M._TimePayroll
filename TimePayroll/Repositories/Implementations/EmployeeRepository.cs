using TimePayroll.Entities;
using TimePayroll.Repositories;

namespace TimePayroll.Repositories.Implementations;

// Заглушка репозитория работников
public class EmployeeRepository : IEmployeeRepository
{
    // Заглушка получения списка работников, пока выбрасывает исключение
    public IEnumerable<Employee> ReadEmployees()
    {
        throw new NotImplementedException();
    }

    // Заглушка получения работника по идентификатору, пока выбрасывает исключение
    public Employee ReadEmployeeById(long id)
    {
        throw new NotImplementedException();
    }

    // Заглушка создания работника, пока выбрасывает исключение
    public void CreateEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }

    // Заглушка изменения работника, пока выбрасывает исключение
    public void UpdateEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }

    // Заглушка удаления работника, пока выбрасывает исключение
    public void DeleteEmployee(long id)
    {
        throw new NotImplementedException();
    }
}