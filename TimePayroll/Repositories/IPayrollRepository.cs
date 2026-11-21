using TimePayroll.Entities;

namespace TimePayroll.Repositories;

// Описывает доступные операции репозитория начислений зарплаты
public interface IPayrollRepository
{
    // Определяет метод получения списка начислений зарплаты
    IEnumerable<Payroll> ReadPayrolls();

    // Определяет метод создания начисления зарплаты
    void CreatePayroll(Payroll payroll);
}