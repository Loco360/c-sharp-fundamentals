using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabor;

namespace NamespacesAndReferencingAssemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.IO.StreamReader myStreamReader = new System.IO.StreamReader();

            //StreamReader myStreamReader = new StreamReader();


            Bob bob = new Bob();

            string html = bob.Lookup("http://www.learnvisualstudio.net");

            Console.WriteLine(html);
            Console.ReadLine();


        }
    }
}
