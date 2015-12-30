using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespacesAndReferencingAssemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will throw a runtime exception if the file does not exist,
            // and is not copied to the compiled binary (see file properties pane).
            StreamReader myStreamReader = new StreamReader("someFilename.txt");
        }
    }
}
