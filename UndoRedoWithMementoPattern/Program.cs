using UndoRedoWithMementoPattern;

// A starting position of a point
var initialPosition = new Position()
{
    X = 0,
    Y = 0
};

// Initialising the PointOriginator
var pointOriginator = new PointOriginator(initialPosition);

// Initialising the Caretaker
var caretaker = new Caretaker(pointOriginator);

// Saving initial state of the point
caretaker.Save();
Console.WriteLine($"PointOriginator currently at: ({pointOriginator.Save().GetPosition().X}, {pointOriginator.Save().GetPosition().Y})");

// Series of moving the point to different positions and saving the state
var northEastPosition  = new Position()
{
    X = 7,
    Y = 4
};
pointOriginator.Move(northEastPosition);
Console.WriteLine($"Moved the point to: ({pointOriginator.Save().GetPosition().X}, {pointOriginator.Save().GetPosition().Y})");

caretaker.Save();

var southWestPosition  = new Position()
{
    X = -3,
    Y = -2
};
pointOriginator.Move(southWestPosition);
Console.WriteLine($"Moved the point to: ({pointOriginator.Save().GetPosition().X}, {pointOriginator.Save().GetPosition().Y})");

caretaker.Save();




// Running a series of undos and redos
Console.WriteLine("Undoing...");
caretaker.Undo();
Console.WriteLine($"Moved the point to: ({pointOriginator.Save().GetPosition().X}, {pointOriginator.Save().GetPosition().Y})");

Console.WriteLine("Undoing...");
caretaker.Undo();
Console.WriteLine($"Moved the point to: ({pointOriginator.Save().GetPosition().X}, {pointOriginator.Save().GetPosition().Y})");

Console.WriteLine("Redoing...");
caretaker.Redo();
Console.WriteLine($"Moved the point to: ({pointOriginator.Save().GetPosition().X}, {pointOriginator.Save().GetPosition().Y})");

Console.WriteLine("Redoing...");
caretaker.Redo();
Console.WriteLine($"Moved the point to: ({pointOriginator.Save().GetPosition().X}, {pointOriginator.Save().GetPosition().Y})");