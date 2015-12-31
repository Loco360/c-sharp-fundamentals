using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
       // private static string k = "";

        static void Main(string[] args)
        {
            /*
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine("l: " + l);
            }
            //Console.WriteLine(i);

            Console.WriteLine("Outsite of the for: " + j);
            //Console.WriteLine("k: " + k);
            helperMethod();
             */


            Car car = new Car();

            car.DoSomething();


            Console.ReadLine();
        }

        /*
        static void helperMethod()
        {
            Console.WriteLine("k from the helperMethod: " + k);
        }
         */ 

    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello world!";
        }

    }

}
