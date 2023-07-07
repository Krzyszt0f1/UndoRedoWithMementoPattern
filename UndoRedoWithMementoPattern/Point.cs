namespace UndoRedoWithMementoPattern;

// Point acts here as an Originator, it produces snapshots (IPoint/PointSnapshots)
// of Point's current state
public class Point
{
    private Position _position;

    public Point(Position position)
    {
        _position = position;
    }

    public void Move(Position position)
    {
        _position = position;
    }

    public IPoint Save()
    {
        return new PointSnapshot(_position);
    }

    public void Restore(IPoint pointSnapshot)
    {
        _position = pointSnapshot.GetPosition();
    }
}