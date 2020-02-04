

// Assignment Operator =
// Arithmetic Operators like +,-,*,/,% 
// Comparison Operators like ==, !=,>, >=, <, <= 
// Conditional Operators like &&, ||
// Ternary Operator ?:
// Null Coalescing Operator ?? 
using System;
namespace Tutorial
{
    class Program
    {
        public static void main()
        {
            int number = 10;
            // Ternary Operator
            bool isNumber;
            isNumber = number == 10 ? true :false;

            Console.WriteLine("Number == 10 is {0}", isNumber);
        }
    }
}

