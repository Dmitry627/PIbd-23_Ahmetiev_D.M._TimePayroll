using TimePayroll.Entities;

namespace TimePayroll.Repositories;

public interface IEmployeeBonusRepository
{
    IEnumerable<EmployeeBonus> ReadEmployeeBonuses();

    void CreateEmployeeBonus(EmployeeBonus bonus);

    void DeleteEmployeeBonus(EmployeeBonus bonus);
}