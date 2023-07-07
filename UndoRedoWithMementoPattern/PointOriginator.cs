namespace UndoRedoWithMementoPattern;

// PointOriginator produces snapshots (IPoint/PointSnapshots)
// of PointOriginator's current state
public class PointOriginator
{
    private Position _position;

    public PointOriginator(Position position)
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