using TimePayroll.Entities;
using TimePayroll.Repositories;

namespace TimePayroll.Repositories.Implementations;

// Заглушка репозитория начислений зарплаты
public class PayrollRepository : IPayrollRepository
{
    // Возвращает пустой список начислений зарплаты для заглушки
    public IEnumerable<Payroll> ReadPayrolls()
    {
        return [];
    }
    
    // Заглушка создания начисления зарплаты без сохранения данных
    public void CreatePayroll(Payroll payroll)
    {
    }
}
