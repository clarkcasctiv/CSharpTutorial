using System;
using System.Reflection;

namespace Pujan
{
    public class MainClass
    {
        private static void Main()
        {
            // Early Binding
            // We know about methods, properties in compile time
            // Customer C1 = new Customer();
            // string fullname = C1.GetFullName("Pujan","Bajra");
            // System.Console.WriteLine("Full Name = {0}", fullname);

            // Late Binding
            // Load the current executing assembly as the Customer class is present in it.
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            // Load the Customer class for which we want to create an instance dynamically
            Type customerType = executingAssembly.GetType("Pujan.Customer");
            // Create the instance of the customer type using Activator class 
            object customerInstance = Activator.CreateInstance(customerType);
            // Get the method information using the customerType and GetMethod()
            MethodInfo getFullName = customerType.GetMethod("GetFullNames");
            // Create the parameter array and populate first and last names
            string[] methodParameters = new string[2];
            methodParameters[0] = "Pujan"; //FirstName
            methodParameters[1] = "Bajra"; //LastName
            // Invoke the method passing in customerInstance and parameters array
            string fullName = (string)getFullName.Invoke(customerInstance, methodParameters);
            Console.WriteLine("Full Name = {0}", fullName);

        }
    }

    public class Customer
    {
        public string GetFullName(string firstName, string lastName)
        {
            return firstName + "" + lastName;
        }
    }
    
}