using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual operaçao deseja fazer:");
            Console.WriteLine("1- adicao:");
            Console.WriteLine("2- Subtraçao:");
            Console.WriteLine("3- multiplicação");
            Console.WriteLine("4- divisao \n");

         
            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o primeiro numero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero:");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }

                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }
                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }

                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }
                default:
                    Console.WriteLine("numero invalido, digite outro numero");
                    break;
            }
            Console.WriteLine("o resultado da operaçao com os numero{0} e {1} é; {2}", num1, num2, resultado);

            Console.ReadLine();
        }

        public static int Adicao(int numero1, int numero2)
        {
            int result = numero1 + numero2;
            return result;
        }

        public static int Subtracao(int numero1, int numero2)
        {
            int result = numero1 - numero2;
            return result;
        }

        public static int Multiplicacao(int numero1, int numero2)
        {
            int result = numero1 * numero2;
            return result;
        }

        public static int Divisao(int numero1, int numero2)
        {
            int result = numero1 / numero2;
            return result;
        }

    }

}
