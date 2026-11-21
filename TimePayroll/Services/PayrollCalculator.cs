using TimePayroll.Entities;
using TimePayroll.Entities.Enums;
using TimePayroll.Repositories;

namespace TimePayroll.Services;

// Рассчитывает начисление работника за месяц
public sealed class PayrollCalculator
{
    // Предоставляет ставки должностей
    private readonly IPositionRepository _positionRepository;

    // Предоставляет записи о выполненной работе
    private readonly IWorkEntryRepository _workEntryRepository;

    // Предоставляет периоды действия надбавок
    private readonly IEmployeeBonusRepository _bonusRepository;

    // Предоставляет коэффициенты и проценты
    private readonly PayrollRates _rates;

    // Принимает данные и правила для расчета
    public PayrollCalculator(IPositionRepository positionRepository, IWorkEntryRepository workEntryRepository, IEmployeeBonusRepository bonusRepository, PayrollRates rates)
    {
        _positionRepository = positionRepository;
        _workEntryRepository = workEntryRepository;
        _bonusRepository = bonusRepository;
        _rates = rates;
    }

    // Суммирует часы, основную оплату и действующие надбавки за месяц
    public Payroll Calculate(Employee employee, DateTime period)
    {
        var monthStart = new DateTime(period.Year, period.Month, 1);
        var nextMonth = monthStart.AddMonths(1);

        var position = _positionRepository.ReadPositions()
            .FirstOrDefault(item => item.Id == employee.PositionId);

        if (position is null || position.HourlyRate is <= 0)
            throw new InvalidDataException("У должности работника должна быть задана почасовая ставка");

        var entries = _workEntryRepository.ReadWorkEntries().Where(entry =>
            entry.EmployeeId == employee.Id &&
            entry.WorkDate >= monthStart &&
            entry.WorkDate < nextMonth);

        var bonuses = _bonusRepository.ReadEmployeeBonuses().Where(bonus =>
            bonus.EmployeeId == employee.Id &&
            bonus.StartDate.Date < nextMonth &&
            bonus.EndDate.Date >= monthStart).ToList();

        var bonusTypes = Enum.GetValues<BonusType>()
            .Where(type => type is not BonusType.None).ToArray();

        decimal totalHours = 0;
        decimal baseSalary = 0;
        decimal bonusAmount = 0;

        foreach (var entry in entries) {
            var day = entry.WorkDate.Date;
            var coefficient = _rates.GetWorkCoefficient((WorkType)entry.WorkType);
            var baseAmount = entry.Hours * position.HourlyRate * coefficient;
            totalHours += entry.Hours;
            baseSalary += baseAmount;

            var activeTypes = BonusType.None;
            foreach (var bonus in bonuses) {
                if (day >= bonus.StartDate.Date && day <= bonus.EndDate.Date) {
                    activeTypes |= (BonusType)bonus.BonusType;
                }
            }

            foreach (var type in bonusTypes) {
                if (activeTypes.HasFlag(type)) {
                    bonusAmount += baseAmount * _rates.GetBonusPercentage(type) / 100m;
                }
            }
        }

        baseSalary = decimal.Round(baseSalary, 2, MidpointRounding.AwayFromZero);
        bonusAmount = decimal.Round(bonusAmount, 2, MidpointRounding.AwayFromZero);

        return Payroll.CreateEntity(
            0, employee.Id, monthStart, totalHours, baseSalary, bonusAmount, baseSalary + bonusAmount);
    }
}
