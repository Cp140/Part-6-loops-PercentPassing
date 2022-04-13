using System;

namespace Part_6__loops_PercentPassing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables declaired
            int grades;            //Input Variable
            int i;                 //Counter Variable
            int loop;              //Loop amount
            int gradesOver70 = 0;  //Counter grades over 70%
            int gradesUnder70 = 0; //Counter grades under 70%
            int gAdded= 0;         //grade added total
            int classAverage = 0;  //Class Average



            Console.WriteLine("How many grades will you enter");
            while (!Int32.TryParse(Console.ReadLine(), out loop))
                Console.WriteLine("Invalid integer, try again.");
            Console.WriteLine($"enter {loop} grades");
            for (i = 1; i <= loop; i++)
            {
                Int32.TryParse(Console.ReadLine(), out grades);
                if(grades >= 69)
                {
                    gradesOver70++;
                }
                else
                {
                    gradesUnder70++;
                }
                gAdded = gAdded + grades;
            }
            Console.WriteLine($"there were {gradesOver70} passing grades (over 70%) and {gradesUnder70} failing grades (under 70%)");
            //Average calculator
            classAverage = gAdded / loop;
            Console.WriteLine($"The average grade was {classAverage}");

        }
    }
}
