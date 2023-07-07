using UndoRedoWithMementoPattern;

// A starting position of a point
var initialPosition = new Position()
{
    X = 0,
    Y = 0
};

// Initialising the originator (a.k.a Point)
var pointToMoveAround = new Point(initialPosition);

// Initialising the Caretaker
var caretaker = new Caretaker(pointToMoveAround);

// Saving initial state of the point
caretaker.Save();
Console.WriteLine($"Point currently at: ({pointToMoveAround.Save().GetPosition().X}, {pointToMoveAround.Save().GetPosition().Y})");

// Series of moving the point to different positions and saving the state
var northEastPosition  = new Position()
{
    X = 7,
    Y = 4
};
pointToMoveAround.Move(northEastPosition);
Console.WriteLine($"Moved the point to: ({pointToMoveAround.Save().GetPosition().X}, {pointToMoveAround.Save().GetPosition().Y})");

caretaker.Save();

var southWestPosition  = new Position()
{
    X = -3,
    Y = -2
};
pointToMoveAround.Move(southWestPosition);
Console.WriteLine($"Moved the point to: ({pointToMoveAround.Save().GetPosition().X}, {pointToMoveAround.Save().GetPosition().Y})");

caretaker.Save();




// Running a series of undos and redos
Console.WriteLine("Undoing...");
caretaker.Undo();
Console.WriteLine($"Moved the point to: ({pointToMoveAround.Save().GetPosition().X}, {pointToMoveAround.Save().GetPosition().Y})");

Console.WriteLine("Undoing...");
caretaker.Undo();
Console.WriteLine($"Moved the point to: ({pointToMoveAround.Save().GetPosition().X}, {pointToMoveAround.Save().GetPosition().Y})");

Console.WriteLine("Redoing...");
caretaker.Redo();
Console.WriteLine($"Moved the point to: ({pointToMoveAround.Save().GetPosition().X}, {pointToMoveAround.Save().GetPosition().Y})");

Console.WriteLine("Redoing...");
caretaker.Redo();
Console.WriteLine($"Moved the point to: ({pointToMoveAround.Save().GetPosition().X}, {pointToMoveAround.Save().GetPosition().Y})");