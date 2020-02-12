
using System;

interface I1
{
    void Print();

}

interface I2
{
    void Print();

}

// Explicit Interface Implementation is used when multiple inherited interface have the method with same method name
// When using explicit interface implementation access modifiers are not permitted
public class Program : I1, I2
{
    void I1.Print()
    {
        System.Console.WriteLine("Print 1");
    }

    void I2.Print()
    {
        System.Console.WriteLine("Print 2");
    }
    public static void Main()
    {
        Program p = new Program();
        ((I1)P).Print();
        ((I2)P).Print();
        
        // Or 

        I1 i1 = new Program();
        I2 i2 = new Program();
        i1.Print();
        i2.Print();

    }
}
