using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, v3;

            Console.Write("Digite o primeiro valor: ");
            v1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            v2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            v3 = double.Parse(Console.ReadLine());

            if (v1 > v2 && v1 > v3)
            {
                Console.WriteLine("O maior valor é: " + v1);
            }
            else if (v2 > v1 && v2 > v3)
            {
                Console.WriteLine("O maior valor é: " + v2);
            }
            else
            {
                Console.WriteLine("O maior valor é: " + v3);
            }
            if (v1 == v2 && v1 == v3)
            {
                Console.WriteLine("Não existe maior valor");
            }
           
            

        }
    }
}
