using Method_Overloading_Exercise_02;

// Complete all of the TODO's here AND in the Methods class


// TODO: Call the rectangle Area method overload with 2 arguments and display to the console
Console.WriteLine(Methods.Area(25, 4));

// TODO: Call the circle Area method overload with 1 argument and display to the console
Console.WriteLine(Methods.Area(10.0));

// TODO: Call the Concatenate method overload with 3 string arguments and display to the console
Console.WriteLine(Methods.Concatenate("first", "second", "third"));

// TODO: Call the Concatenate method overload with a string[] of arguments and display to the console
Console.WriteLine(Methods.Concatenate(new string[] { "first", "second", "third", "fourth", "fifth" }));

// TODO: Call the SetCoordinate method overload with 3 arguments and display to the console (use string interpolation)
var coordinate = Methods.SetCoordinate(2, 2, 2);
Console.WriteLine($"This method creates a new {coordinate.GetType().Name} from 3 arguments (x,y,z)");
Console.WriteLine($"X: {coordinate.X}");
Console.WriteLine($"Y: {coordinate.Y}");
Console.WriteLine($"Z: {coordinate.Z}");
