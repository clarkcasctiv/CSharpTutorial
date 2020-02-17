using System;

namespace csharptutorial
{
    public class Enums
    {
        public static void Main()
        {
            Customer C1 = new Customer
            {
                Name = "Mark",
                Gender = (int)Gender.Male
            };

            int[] values = (int[])Enum.GetValues(typeof(Gender));
            foreach (int value in values)
            {
                System.Console.WriteLine(value);

            }


            string[] names = Enum.GetNames(typeof(Gender));
            foreach (string name in names)
            {
                System.Console.WriteLine(name);

            }

            // Explicit Conversion is needed to convert from enum type to integral type and vice versa
            Gender gender = (Gender)3;
            int num = (int)Gender.Unknown;

            Gender gen = (Gender)Season.Autumn;

        }
    }

    public class Customer
    {
        public int Gender { get; set; }
        public string Name { get; set; }
    }

    public enum Gender : short
    {
        Unknown = 1,
        Male = 2,
        Female = 3

    }

    public enum Season 
    {
        Summer,
        Winter,
        Autumn
    }

}