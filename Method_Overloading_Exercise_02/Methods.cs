using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Exercise_02;
internal class Methods
{
    /// <summary>
    /// Calculates the Area of the square
    /// </summary>
    /// <param name="side">The length of the side of the square</param>
    /// <returns>The Area</returns>
    public static double Area(double side)
    {
        return Math.Pow(side, 2);
    }

    // TODO: Create 2 overloads of the Area method above
    // 1 for a rectangle Area(double length, double width)
    // 1 for a circle Area(double radius)

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

    // TODO: Create 2 overloads of the Concatenate method above
    // 1 for taking in 3 strings Concatenate(string str1, string str2, string str3)
    // 1 for taking an Array of strings Concatenate(string[] strs)

}
