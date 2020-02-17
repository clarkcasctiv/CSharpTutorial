using System;

namespace csharptutorial
{
    public class ExceptionHandlingAbuse
    {
        public static void Main()
        {
            try
            {
                System.Console.WriteLine("Enter Numerator:");
                int numerator;

                bool isNumerator = int.TryParse(Console.ReadLine(), out numerator);

                if (isNumerator)
                {
                    System.Console.WriteLine("Enter Denominator:");
                    int denominator;

                    bool isDenominator = int.TryParse(Console.ReadLine(), out denominator);

                    if (isDenominator && denominator != 0)
                    {

                        int result = numerator / denominator;
                        System.Console.WriteLine("Result = {0}", result);

                    }
                    else
                    {
                        if (denominator == 0)
                        {
                            System.Console.WriteLine("Denominator cannot be zero");
                        }
                        else
                        {
                            System.Console.WriteLine("Denominator must be a number!");
                        }

                    }

                }
                else
                {

                    System.Console.WriteLine("Numerator must be a number!");
                }
            }
            catch (System.Exception)
            {

                throw;
            }

        }
    }
}
