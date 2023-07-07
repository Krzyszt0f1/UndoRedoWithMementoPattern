namespace UndoRedoWithMementoPattern;

// Interface to declare the shape of PointSnapshot, i.e., the Memento
public interface IPoint
{
    Position GetPosition();
}