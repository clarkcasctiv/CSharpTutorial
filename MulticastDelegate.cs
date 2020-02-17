//Multicast delegate makes implementation of observer design pattern very simple. Observer design pattern is also called publish/subscribe pattern;

// Multicast delegate is a delegate which references more than one funcion. When invoking a multicast delegate all the functions in the delegate are invoked.
using System;

public delegate void SampleDelegate();
public class Sample
{
    static void Main()
    {
        // + or += to register
        // - Or -= to unregister
        // delegates are invoked in the same order they are added


        // SampleDelegate del1, del2, del3, del4;
        // del1 = new SampleDelegate(One);
        // del2 = new SampleDelegate(Two);
        // del3 = new SampleDelegate(Three);
        // del4 = del1 + del2 - del3;
        // del4();

        // Or
        SampleDelegate del = new SampleDelegate(One);
        del += Two;
        del += Three;
        del -= One;
        del();

    }

    public static void One()
    {
        System.Console.WriteLine("One");
    }

    public static void Two()
    {
        System.Console.WriteLine("Two");
    }

    public static void Three()
    {
        System.Console.WriteLine("Three");
    }


}