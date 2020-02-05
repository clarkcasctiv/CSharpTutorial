
// Implicit Conversion

// Implicit Conversion is done by compiler when there is no loss of data during the conversion and no possibility of throwing exception
// Ex. Converting a int to a float
// Smaller datatype To Bigger datatype

// Explicit Conversion

// In Explicit conversion there is loss of data and possibility of overflow exception
// Ex. Converting a float to a int
// Bigger datatype To smaller datatype
// (int) Typecast operator is Used for Explicit conversion


using System;
namespace Tutorial
{
    class Program
    {
        public static void main()
        {
            // Implicit Conversion
            int i = 100;
            float f = i;

            Console.Writeline(f);

            float g = 123.45;
            int j = (int)f;

            Console.Writeline(j);

            // Using a typecast operator wont throw exception whereas Convert class will throw Overflow Exception
            float k = 12314511515151515.123123;
            int q = (int)f;
            int w = Convert.ToInt32(f);

            string str = "100TF";
            int result = 0;
            int t = int.Parse(str); // throws exception
            bool conversion = int.TryParse(str, out result); // wont throw exception, returns true if conversion is successful else false 
            Console.WriteLine(t);
            Console.WriteLine(result);




        }
    }
}




