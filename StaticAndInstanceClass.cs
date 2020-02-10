using System;

class Circle
{
    static float _PI;
    int _radius;

    static Circle()
    {
        _PI = 3.14;

    }

    public Circle(int radius)
    {
        this._radius = radius;
    }

    public float CalculateArea()
    {
        return Circle._PI * this._radius * this._radius;
    }

    public static void PrintRadius()
    {
        return this._radius;
    }
}

class Program
{
    public static void Main()
    {
        Circle c1 = new Circle(5);
        Circle.PrintRadius();
        float area = c1.CalculateArea();
        System.Console.WriteLine("Area = {0}", area);

    }
}

//Static members are invoked using class name , where as instance members are invoked using instances(objects) of the class.

// Static members cannot be referred using this 

// Static constructors are called only once;
// Static constructors cannot have public access modifier
// Static constructors are used to initialize static fields
// Static constructors are initialized before instance constructors
