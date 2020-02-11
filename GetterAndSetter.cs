using System;

public class Student {
    private int _id;
    private string _name;
    private int _passMark = 35;

    public void SetId(int Id)
    {
        if(Id <= 0)
        {
            throw new Exception("Student Id cannot be negative");
        }
        this._id = Id;
    }

    public void SetName(string Name)
    {
        if(String.IsNullOrEmpty(Name))
        {
            throw new Exception("Student Name cannot be empty");
        }

        this._name = Name;
    }



    public string GetName()
    {
        return String.IsNullOrEmpty(this._name) ? "No Name" : this._name;
        

    }

    public int GetId()
    {
        return this._id;
    }

    public int GetPassMark()
    {
        return this._passMark;
    }
}

public class Program
{
    public static void Main()
    {
        Student C1 = new Student();
        C1.SetId(111);
        C1.SetName("Mark");
        System.Console.WriteLine("Student Id = {0}", C1.GetId());
        System.Console.WriteLine("Student Name = {0}", C1.GetName());
        System.Console.WriteLine("Student PassMark = {0}", C1.GetPassMark());
    }
    
}