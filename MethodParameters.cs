class Program
{
    public static void main()
    {
        // Passing By Value
        int i = 0;
        SimpleMethod(i);
        System.Console.WriteLine(i);

        // Value of i will be 0
        // Creates a copy of the parameter passed.
        // Refers to different memory location.

        // Passing By Reference
        int j = 0;
        SimpleMethod(ref j);
        System.Console.WriteLine(i);

        // Value of j will be 101
        // Doesn't create a copy
        // Refers to the same memory location.

        // Out Parameters
        int sumValue = 0;
        int productValue = 0;
        Calculate(5, 10, out sumValue, out productValue);
        System.Console.WriteLine(sumValue);
        System.Console.WriteLine(productValue);

        // Parameter Arrays
        int[] numbers = new int[3];
        numbers[0] = 101;
        numbers[1] = 102;
        numbers[2] = 103;
        ParamsMethod();
        ParamsMethod(numbers);
        ParamsMethod(1, 2, 3, 4, 5);

        // Parameter arrays can be used to pass variable number of arguments, arrays or none at all.
        // Should be the last argument
        // Only one params should be used

    }

    public static void SimpleMethod(int k)
    {
        int k = 101;
    }

    public static void SimpleMethod1(ref int l)
    {
        int l= 101;
    }

    public static void Calculate(int a, int b, out int sum, out int product)
    {
        sum = a + b;
        product = a * b;
    }

    public static void ParamsMethod(params int[] numbers)
    {
        foreach (int i in numbers)
        {
            System.Console.WriteLine(i);

        }
    }


    // When creating methods => Parameters
    //public static void NewSum(int a, int b)

    // When invoking methods => Arguments
    //NewSum(5,10);

}