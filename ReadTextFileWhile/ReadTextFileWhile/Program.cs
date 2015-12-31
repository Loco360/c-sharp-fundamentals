using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                StreamReader myReader = new StreamReader("Values.txt");
                string line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                        Console.WriteLine(line);
                }

                myReader.Close();
            }
            catch
            {
                Console.WriteLine("Something didn't quite work correctly.");
            }

            Console.ReadLine();
        }
    }
}
