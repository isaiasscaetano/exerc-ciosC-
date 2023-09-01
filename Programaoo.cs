using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, raio;
            raio = Convert.ToDouble(Console.ReadLine());
            area = 3.14159 * Math.Pow(raio, 2);
            Console.WriteLine("A ={0}", area.ToString("0,0000"));

            Console.ReadKey();

        }
    }
}
