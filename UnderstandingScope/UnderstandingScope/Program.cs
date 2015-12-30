using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        // Declaring at this level makes it a field of the class
        //private static string k = "";

        static void Main(string[] args)
        {
            //string j = "";

            //for (int i = 0; i < 10; i++)
            //{
            //    j = i.ToString();
            //    k = i.ToString();
            //    Console.WriteLine(i);

            //    if (i == 9)
            //    {
            //        string l = i.ToString();
            //    }
            //    // This will not compile, as i is scoped to the condition block
            //    //Console.WriteLine("l: " + l);
            //}
            
            //// This will not compile, as i is scoped to the for loop only
            ////Console.WriteLine(i);

            //// This will compile, as j is declared outside of the foor loop, and accessible from both inside and outside of the loop
            //Console.WriteLine("Outside of the for: " + j);

            //// This will compile, as k is declared at the class level, and accessible anywhere within the class' children
            ////Console.WriteLine("k: " + k);

            //// This helperMethod call is a child of the class level, and therefore will know about k within the method
            //HelperMethod();

            Car car = new Car();

            // GOOD
            car.DoSomething();

            // WILL NOT WORK
            //car.HelperMethod();
            
            Console.ReadLine();
        }

        //static void HelperMethod()
        //{
        //    // This helperMethod will know about k, as it was defined at the class level
        //    Console.WriteLine("k from the helperMethod: " + k);
        //}
    }

    class Car
    {
        // Consumers will see this method, which calls its own private method
        // public method/var naming convention states that it should be PascalCase
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        // Consumers will not see this method (effectively hidden implementation)
        // private method naming convention states that it should be camelCase
        private string helperMethod()
        {
            return "Hello world!";
        }
    }
}
