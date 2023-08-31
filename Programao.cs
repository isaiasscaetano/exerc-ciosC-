// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization;
using System;
internal class Program
{
    private static void Main(string[] args)
    {            
        int n1, n2, somas;

        Console.WriteLine("Digite o primeiro número: ");
         n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
         n2 = int.Parse(Console.ReadLine());


        somas = n1 + n2;


        Console.WriteLine("O resultado da soma é: " + somas);


                Console.ReadKey();
            
        
    }
}