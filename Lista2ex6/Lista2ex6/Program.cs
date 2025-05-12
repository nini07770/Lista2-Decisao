using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.Write("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 20 )
            {
                Console.WriteLine("Abaixo do peso");
            }
            if (imc >= 20 && imc < 25)
            {
                Console.WriteLine("Peso ideal");
            }
            if (imc >= 25 )
            {
                Console.WriteLine("Acima do peso");
            }
        }
    }
}
