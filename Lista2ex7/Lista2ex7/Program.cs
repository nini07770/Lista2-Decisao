using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3;

            Console.Write("Digite o primeiro lado: ");
            lado1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo lado: ");
            lado2 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro lado: ");
            lado3 = Double.Parse(Console.ReadLine());

            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            {
                Console.WriteLine("Os lados formam um triângulo.");
            }
            else
            {
                Console.WriteLine("Os lados não formam um triângulo.");
                return;
            }

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("O triângulo é equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("O triângulo é isósceles.");
            }
            else
            {
                Console.WriteLine("O triângulo é escaleno.");
            }
        }

    }
}
