namespace UndoRedoWithMementoPattern;

// Caretaker manages the Undo Redo stacks and decides when to save the Memento (to take a snapshot of Point state)
public class Caretaker
{
    private Stack<IPoint> _undoStack = new();
    private Stack<IPoint> _redoStack = new();

    private Point _point;

    public Caretaker(Point point)
    {
        _point = point;
    }

    public void Save()
    {
        _undoStack.Push(_point.Save());
    }

    public void Undo()
    {
        if (_undoStack.Count > 0)
        {
            _redoStack.Push(_undoStack.Pop());
            _point.Restore(_undoStack.Peek());
        }
    }

    public void Redo()
    {
        if (_redoStack.Count > 0)
        {
            // reversal of operation order in redo ensures correct stack writing
            // and Point restoring
            _point.Restore(_redoStack.Peek());
            _undoStack.Push(_redoStack.Pop());
        }
        
    }
}