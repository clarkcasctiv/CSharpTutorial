// Difference between & an &&
// && || => Short Circuit Operators
// For boolean types, where both of them can be applied, the difference is in the "short-circuiting" property of &&. 
//If the first operand of && evaluates to false, the second is not evaluated at all.This is not the case for &:
// If the first operand of || evaluates to true, the second is not evaluated at all.This is not the case for |:

// Conditional Branching
// If 
// If Else
// If Else if
// Switch

// Conditional Looping
// While
// Do While
// For
// For Each

// Initialization; Conditional; Iteration

namespace CSharpTutorial
{

    class Program
    {
        public static void main()
        {
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);

            }
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine(numbers[i]);
            }
            int j = 0;
            while (j < numbers.Length)
            {
                System.Console.WriteLine(numbers[j]);
                j++;
            }


        }

    }
}

// break = => stops executing the loop
// continue => stops execeuting the current iteration of the loop