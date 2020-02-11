using System;

public class Student
{
    private int _id;
    private string _name;
    private int _passMark = 35;
    private string _address;

    private string _number;
    public string _number
    {
        get
        {
            return _number;
        }
        set
        {
            _number = value;
        }
    }

    public string Address
    {
        get
        {
            return this._address;
        }
        set
        {
            this._address = value;
        }
        
    }
    // Auto Implemented Property
    // Similar To
    public string City { get; set; }
    public int Id
    {
        get
        {
            if (value <= 0)
            {
                throw new Exception("Student Id cannot be negative");
            }
            this._id = value;
        }
        set
        {
            return this._id;
        }
    }

    // Read/Write Property
    public string Name
    {
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new Exception("Student Name cannot be empty");
            }
            this._name = value;
        }
        get
        {
            return String.IsNullOrEmpty(this._name) ? "No Name" : this._name;
        }
    }

    // Read Only Property
    public int PassMark
    {
        get
        {
            return this._passMark;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Student C1 = new Student();
        C1.Id = 111;
        C1.Name = "Mark";
        System.Console.WriteLine("Student Id = {0}", C1.Id);
        System.Console.WriteLine("Student Name = {0}", C1.Name);
        System.Console.WriteLine("Student PassMark = {0}", C1.PassMark);
    }

}