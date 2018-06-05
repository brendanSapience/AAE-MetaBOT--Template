using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCustomAppLibrary;

namespace CustomAppTests
{
    class Program
    {
        static void Main(string[] args)
        {
            UsefulMethods methods = new UsefulMethods();
            String Res = methods.GetGreeting("Bren");
            Console.WriteLine("Debug:" + Res);
            Console.ReadKey();
        }
    }
}
