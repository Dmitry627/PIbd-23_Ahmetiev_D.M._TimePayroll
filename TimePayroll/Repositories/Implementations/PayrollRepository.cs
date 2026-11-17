using TimePayroll.Entities;
using TimePayroll.Repositories;

namespace TimePayroll.Repositories.Implementations;

// Заглушка репозитория начислений зарплаты
public class PayrollRepository : IPayrollRepository
{
    // Заглушка получения списка начислений зарплаты, пока выбрасывает исключение
    public IEnumerable<Payroll> ReadPayrolls()
    {
        throw new NotImplementedException();
    }
    
    // Заглушка создания начисления зарплаты, пока выбрасывает исключение
    public void CreatePayroll(Payroll payroll)
    {
        throw new NotImplementedException();
    }
}
