using System;

namespace Part_6__loops_PercentPassing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables declaired
            int grades;



            Console.WriteLine("Please enter an integer:");
            while (Int32.TryParse(Console.ReadLine(), out grades))
                Console.WriteLine("Invalid integer, try again.");
            


            Console.WriteLine($"Thanks for {number}!");
        }
    }
}
