using TimePayroll.Entities;

namespace TimePayroll.Repositories;

// Описывает доступные операции репозитория должностей
public interface IPositionRepository
{
    // Определяет метод получения списка должностей
    IEnumerable<Position> ReadPositions();

    // Определяет метод получения должности по идентификатору
    Position ReadPositionById(int id);

    // Определяет метод создания должности
    void CreatePosition(Position position);

    // Определяет метод изменения должности
    void UpdatePosition(Position position);

    // Определяет метод удаления должности
    void DeletePosition(Position position);
}