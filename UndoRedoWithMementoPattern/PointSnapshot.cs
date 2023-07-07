namespace UndoRedoWithMementoPattern;

// Concrete implementation of a Memento of a Point
public class PointSnapshot : IPoint
{
    private Position _position;

   public PointSnapshot(Position position)
    {
        _position = position;
    }

    public Position GetPosition()
    {
        return _position;
    }
}