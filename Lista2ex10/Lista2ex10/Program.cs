using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1, p2;
            double media;

            Console.Write("Digite a nota da sua primeira prova: ");
            p1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da sua segunda prova: ");
            p2 = Double.Parse(Console.ReadLine());

            media = (p1 + 2 * p2) / 3;

            if (media >= 5)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
