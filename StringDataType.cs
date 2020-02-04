

// Verbatim Literal -> @
// Verbatim literals make escape sequences translate as normal printable characters to enhance readability. 

using System;
class Program
{
    public static void main()
    {
        // Displaying double quotes in c#
        string Name = "\"Pujan\"";
        Console.WriteLine(Name);

        // Displaying new line character in c#
        Name = "One\nTwo\nThree";
        Console.WriteLine(Name);

        // Displaying new line character in c#
        Name = "c:\\Pujan\\DotNet\\Training\\Csharp";
        Console.WriteLine(Name);

        // C# verbatim literal
        Name = @"c:\Pujan\DotNet\Training\Csharp";
        Console.WriteLine(Name);
    }

}