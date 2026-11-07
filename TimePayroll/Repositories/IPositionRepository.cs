using TimePayroll.Entities;

namespace TimePayroll.Repositories;

public interface IPositionRepository
{
    IEnumerable<Position> ReadPositions();

    Position ReadPositionById(int id);

    void CreatePosition(Position position);

    void UpdatePosition(Position position);

    void DeletePosition(Position position);
}