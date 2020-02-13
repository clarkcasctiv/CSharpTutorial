

using System;

class Program
{
    public static void Main()
    {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 10000, Experience = 5 });
        empList.Add(new Employee() { ID = 102, Name = "John", Salary = 15000, Experience = 4 });
        empList.Add(new Employee() { ID = 103, Name = "Sal", Salary = 7000, Experience = 7 });
        empList.Add(new Employee() { ID = 104, Name = "Ryan", Salary = 9000, Experience = 2 });

        //IsPromotable isPromotable = new IsPromotable(Promote);

        // Employee.PromoteEmployee(empList,isPromotable);

        // Using Lambda expression, lambda expression uses delegates
        Employee.PromoteEmployee(empList,emp => emp.Experience >=5);
    }

    // public static bool Promote(Employee emp)
    // {
    //     if(emp.Experience >= 5)
    //     {
    //         return true;
    //     }
    //     else
    //     {            
    //         return false;
    //     }
    // }
}

delegate bool IsPromotable(Employee empl);

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    // public static void PromoteEmployee(List<Employee> employeeList)
    // {
    //     foreach (Employee employee in employeeList)
    //     {
    //         if (employee.Experience >= 5)
    //         {
    //             System.Console.WriteLine(employee.Name + "Promoted");
    //         }
    //     }
    // }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligible)
    {
        foreach (Employee employee in employeeList)
        {
            if (IsEligible(employee))
            {
                System.Console.WriteLine(employee.Name + "Promoted");
            }
        }
    }


}
