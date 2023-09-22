
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int n, q, lim;


        Console.Write("digite um numero");
        q = Convert.ToInt32(Console.ReadLine());
        Console.Write("qual e o seu limite");
        lim = Convert.ToInt32(Console.ReadLine());
        n = 1;
        while (n <= lim)
        {
            Console.Write("{0} x {1} = {2}\n", q, n, q * n);
            n++;


        }

        Console.Write("\n------- while -------\n");
        n = 1;
        while (n <= 5){
            Console.Write("{0\n}", n);
            n++;
        }

        Console.WriteLine("\n------- d0 -------\n");
        n = 1;
        do{
            Console.Write("{0}\n", n);
            n++;


        } while (n <= 5);

       



    }
}
