using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baze, altura, area;

            Console.WriteLine("Digite a base do retângulo: ");
            baze = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo: ");
            altura = double.Parse(Console.ReadLine());

            area = baze * altura;

            Console.WriteLine("A área do retângulo é:{0} " , area);

            if (area > 100)
            {
                Console.WriteLine("Terreno grande");
            }
           

        }
    }
}
