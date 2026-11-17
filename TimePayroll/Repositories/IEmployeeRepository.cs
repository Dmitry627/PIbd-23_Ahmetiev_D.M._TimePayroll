using TimePayroll.Entities;

namespace TimePayroll.Repositories;

// Описывает доступные операции репозитория работников
public interface IEmployeeRepository
{
    // Определяет метод получения списка работников
    IEnumerable<Employee> ReadEmployees();

    // Определяет метод получения работника по идентификатору
    Employee ReadEmployeeById(long id);

    // Определяет метод создания работника
    void CreateEmployee(Employee employee);

    // Определяет метод изменения работника
    void UpdateEmployee(Employee employee);

    // Определяет метод удаления работника
    void DeleteEmployee(long id);
}