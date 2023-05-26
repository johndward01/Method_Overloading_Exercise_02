namespace Method_Overloading_Exercise_02;

internal class Methods
{

    // TODO: Create 2 overloads of the Area method
    // 1 for a rectangle Area(double length, double width)
    // 1 for a circle Area(double radius)

    /// <summary>
    /// Calculates the Area of the square
    /// </summary>
    /// <param name="side">The length of the side of the square</param>
    /// <returns>The Area</returns>
    public static double Area(int side)
    {
        return Math.Pow(side, 2);
    }



    // TODO: Create 2 overloads of the Concatenate method 
    // 1 for taking in 3 strings Concatenate(string str1, string str2, string str3)
    // 1 for taking an Array of strings Concatenate(string[] strs)

    /// <summary>
    /// Combines the strings into 1 string
    /// </summary>
    /// <param name="str1">The first string</param>
    /// <param name="str2">The second string</param>
    /// <returns>The combined string</returns>
    public static string Concatenate(string str1, string str2)
    {
        return str1 + str2;
    }


    // TODO: Create an overload of the SetCoordinate Method 
    // for taking 3 parameters SetCoordinate(int x, int y, int z)
    // hint: you will need to use the Coordinate class below

    /// <summary>
    /// Sets a Coordinate
    /// </summary>
    /// <param name="x">Represents the x-axis</param>
    /// <param name="y">Represents the y-axis</param>
    /// <returns>An instance of a Coordinate class with the X and Y fields set</returns>
    public static Coordinate SetCoordinate(int x, int y)
    {
        return new Coordinate(x, y);
    }
}


public class Coordinate
{
    public Coordinate(double x, double y)
    {
        X = x;
        Y = y;
    }
    double X;
    double Y;
}