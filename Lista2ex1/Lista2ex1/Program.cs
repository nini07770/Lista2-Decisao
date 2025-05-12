using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;

            Console.WriteLine("Digite o primeiro valor: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            n2 = double.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("Maior valor: " + n1);
            }
            else if (n2 > n1)
            {
                Console.WriteLine("Maior valor: " + n2);
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

