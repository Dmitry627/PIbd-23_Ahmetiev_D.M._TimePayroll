using TimePayroll.Entities;
using TimePayroll.Repositories;

namespace TimePayroll.Repositories.Implementations;

public class PayrollRepository : IPayrollRepository
{
    public IEnumerable<Payroll> ReadPayrolls()
    {
        throw new NotImplementedException();
    }
    
    public void CreatePayroll(Payroll payroll)
    {
        throw new NotImplementedException();
    }
}
