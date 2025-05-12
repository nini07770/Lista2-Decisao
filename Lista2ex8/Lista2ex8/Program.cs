using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Digite o lado a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado c: ");
            c = double.Parse(Console.ReadLine());

            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                Console.WriteLine("Os lados formam um triângulo retângulo.");
            }
            else
            {
                Console.WriteLine("Os lados não formam um triângulo retângulo.");
            }
        }
    }
}
