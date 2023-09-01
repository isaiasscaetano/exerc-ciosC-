using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media1
{
    internal class media1
    {
        static void Main(string[] args)
        {
            double av1, av2, media;
            av1 = Convert.ToDouble(Console.ReadLine());
            av2 = Convert.ToDouble(Console.ReadLine());

            media = (av1 * 3.5 + av2 * 7.6) / (3.5 + 7.5);
            Console.WriteLine("media = {0}", media.ToString("0.00000"));

            Console.ReadKey();
        }
    }
}
