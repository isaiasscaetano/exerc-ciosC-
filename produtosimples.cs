using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, produto;
           
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            produto = a * b;

            Console.WriteLine("prod = {0}", produto);

            Console.ReadKey();
        }
    }
}
