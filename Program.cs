using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lissonfour
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            double y = 8.5;
            string z = "A";
            Print<int>(x, "x");
            Print<double>(y, "y");
            Print<string>(z, "z");

            SwapL<int>listI= new SwapL<int>() {1,2,3};
            Console.WriteLine(listI[0]);
            listI.SwapList(0, 2);
            Console.WriteLine(listI[0]);

            SwapL<string> listS = new SwapL<string>() { "rut", "yossi", "Tamar" };
            Console.WriteLine(listS[0]);
            listS.SwapList(0, 2);
            Console.WriteLine(listS[0]);
            Console.Read();

        }
        static void Print<T>(T obj, string NameObj) 
        { 
            Console.WriteLine(NameObj + " = " + obj);
        }
    }
}
