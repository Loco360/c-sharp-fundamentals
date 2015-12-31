using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number between 1 and 100:");
            string userValue = Console.ReadLine();

            int compareValue = int.Parse(userValue);

            if ((compareValue < 1) || (compareValue > 100))
                Console.WriteLine("The number you chose was out of bounds.");
            else if ((compareValue == 42) || (compareValue > 90))
                Console.WriteLine("You found one of the special numbers!");
            else
                Console.WriteLine("You didn't find one of the special numbers");

            Console.ReadLine();

        }
    }
}
