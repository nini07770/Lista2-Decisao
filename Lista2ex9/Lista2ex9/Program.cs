using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;
            string sexo;

            Console.Write("Digite seu peso em kg:");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura em metros:");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite seu sexo (M ou F):");
            sexo = Console.ReadLine().ToUpper();

            imc = peso / (altura * altura);

            if (sexo == "F")
            {
                if (imc < 19)
                    Console.WriteLine("Abaixo do peso");
                else if (imc >= 19 && imc < 24)
                    Console.WriteLine("Peso ideal");
                else
                    Console.WriteLine("Acima do peso");
            }
            else if (sexo == "M")
            {
                if (imc < 20)
                    Console.WriteLine("Abaixo do peso");
                else if (imc >= 20 && imc < 25)
                    Console.WriteLine("Peso ideal");
                else
                    Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Sexo inválido");
            }
        }
    }
}
