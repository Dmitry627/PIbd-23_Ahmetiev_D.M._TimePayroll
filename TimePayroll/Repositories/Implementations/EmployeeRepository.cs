using TimePayroll.Entities;
using TimePayroll.Repositories;

namespace TimePayroll.Repositories.Implementations;

public class EmployeeRepository : IEmployeeRepository
{
    public IEnumerable<Employee> ReadEmployees()
    {
        throw new NotImplementedException();
    }

    public Employee ReadEmployeeById(long id)
    {
        throw new NotImplementedException();
    }

    public void CreateEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }

    public void UpdateEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }

    public void DeleteEmployee(long id)
    {
        throw new NotImplementedException();
    }
}