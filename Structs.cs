using System;

public struct Student
{
    private int _id;
    private string _name;

    public Student(int Id, string Name)
    {
        _id = Id;
        _name = Name;
    }

    public string Id
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

}

public class Program
{
    public static void Main()
    {
        Student C1 = new Student(101, "Mark");

        Student C2 = new Student();
        C2.Id = 111;
        C2.Name = "John";

        // Object Initialization Syntax
        Student C3 = new Student{
            Id = 123,
            Name = "Rob"
        };
 
    }

}