// Value Types  - int, float, double, structs, enums etc
// Reference Types – Interface, Class, delegates, arrays etc

// By default value types are non nullable.To make them nullable use?
// int i = 0(i is non nullable, so "i" cannot be set to null, i = null will generate compiler error)
// int? j = 0(j is nullable int, so j = null is legal)

using System;
namespace Tutorial
{
    class Program
    {
        public static void Main()
        {
            // Null Coalescing Operator
            // Set another value if value is null
            int AvailableTickets;
            int? TicketsOnSale = null;

            AvailableTickets = TicketsOnSale ?? 0;
            Console.WriteLine("Available Tickets = {0}", AvailableTickets);
        }
    }
}
