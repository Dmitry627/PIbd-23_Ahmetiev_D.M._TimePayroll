using TimePayroll.Entities;

namespace TimePayroll.Repositories;

public interface IPayrollRepository
{
    IEnumerable<Payroll> ReadPayrolls();

    void CreatePayroll(Payroll payroll);
}