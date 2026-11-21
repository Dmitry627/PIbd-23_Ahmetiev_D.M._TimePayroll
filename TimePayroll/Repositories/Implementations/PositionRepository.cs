using TimePayroll.Entities;
using TimePayroll.Repositories;

namespace TimePayroll.Repositories.Implementations;

// Заглушка репозитория должностей
public class PositionRepository : IPositionRepository
{
    // Возвращает пустой список должностей для заглушки
    public IEnumerable<Position> ReadPositions()
    {
        return [];
    }

    // Заглушка получения должности по идентификатору, пока выбрасывает исключение
    public Position ReadPositionById(int id)
    {
        throw new NotImplementedException();
    }

    // Заглушка создания должности, пока выбрасывает исключение
    public void CreatePosition(Position position)
    {
        throw new NotImplementedException();
    }

    // Заглушка изменения должности, пока выбрасывает исключение
    public void UpdatePosition(Position position)
    {
        throw new NotImplementedException();
    }

    // Заглушка удаления должности, пока выбрасывает исключение
    public void DeletePosition(Position position)
    {
        throw new NotImplementedException();
    }
}
