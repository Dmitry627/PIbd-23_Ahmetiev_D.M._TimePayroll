using TimePayroll.Entities;

namespace TimePayroll.Repositories;

public interface IEmployeeRepository
{
    IEnumerable<Employee> ReadEmployees();

    Employee ReadEmployeeById(long id);

    void CreateEmployee(Employee employee);

    void UpdateEmployee(Employee employee);

    void DeleteEmployee(long id);
}