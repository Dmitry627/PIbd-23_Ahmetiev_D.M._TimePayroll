using TimePayroll.Entities.Enums;

namespace TimePayroll.Services;

// Хранит правила оплаты по видам работ и надбавок
public sealed class PayrollRates
{
    // Хранит множители почасовой ставки по видам работ
    private readonly IReadOnlyDictionary<WorkType, decimal> _workCoefficients;

    // Хранит проценты по видам надбавок
    private readonly IReadOnlyDictionary<BonusType, decimal> _bonusPercentages;

    // Принимает коэффициенты и проценты для расчета
    public PayrollRates(IReadOnlyDictionary<WorkType, decimal> workCoefficients, IReadOnlyDictionary<BonusType, decimal> bonusPercentages)
    {
        _workCoefficients = workCoefficients;
        _bonusPercentages = bonusPercentages;
    }

    // Возвращает коэффициент для выполненной работы
    public decimal GetWorkCoefficient(WorkType type)
    {
        if (!_workCoefficients.TryGetValue(type, out var coefficient) || coefficient is <= 0)
            throw new InvalidDataException($"Укажите коэффициент для вида работы {type}");

        return coefficient;
    }

    // Возвращает процент надбавки
    public decimal GetBonusPercentage(BonusType type)
    {
        if (!_bonusPercentages.TryGetValue(type, out var percentage) || percentage is < 0)
            throw new InvalidDataException($"Укажите процент для надбавки {type}");

        return percentage;
    }
}
