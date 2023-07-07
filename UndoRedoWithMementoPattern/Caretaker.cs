namespace UndoRedoWithMementoPattern;

// Caretaker manages the Undo Redo stacks and decides when to save the Memento (to take a snapshot of PointOriginatorOriginator state)
public class Caretaker
{
    private Stack<IPoint> _undoStack = new();
    private Stack<IPoint> _redoStack = new();

    private PointOriginator _pointOriginator;

    public Caretaker(PointOriginator pointOriginator)
    {
        _pointOriginator = pointOriginator;
    }

    public void Save()
    {
        _undoStack.Push(_pointOriginator.Save());
    }

    public void Undo()
    {
        if (_undoStack.Count > 0)
        {
            _redoStack.Push(_undoStack.Pop());
            _pointOriginator.Restore(_undoStack.Peek());
        }
    }

    public void Redo()
    {
        if (_redoStack.Count > 0)
        {
            // reversal of operation order in redo ensures correct stack writing
            // and PointOriginator restoring
            _pointOriginator.Restore(_redoStack.Peek());
            _undoStack.Push(_redoStack.Pop());
        }
        
    }
}