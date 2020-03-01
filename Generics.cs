// Boxing => Conversion of value type to ref type

// Generics allow us to design classes and methods decoupled from the data types. Generic classes are extensively used by collection classes .
namespace Generics
{
    public class Program
    {
        public static void Main()
        {
            bool equal = Calculator<int>.AreEqual(5, 5);
            // bool equal = Calculator.AreEqual<int>(5, 5);
            if(equal)
            {
                System.Console.WriteLine("Equal");
            }
            else
            {
                System.Console.WriteLine("Not Equal");
            }
        }
    }


    // public class Calculator
     public class Calculator<T>

    {
        // public static bool AreEqual<T>(T Value1, T Value2)
        public static bool AreEqual(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}