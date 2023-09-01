using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estremafacil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;
            a = Convert.ToInt32(Console.ReadLine());
           
            b = Convert.ToInt32(Console.ReadLine());
           
            x = a + b;

            Console.WriteLine("x = " + x);

            Console.WriteLine("x = {0}", x);
            Console.WriteLine("a = {0} e b = {1} e {2}", a, b, x);

            Console.ReadKey();
           
                
                
        }
    }
}
