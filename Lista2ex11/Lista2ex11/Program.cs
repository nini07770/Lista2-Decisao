using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double segnota;

            //(3*5 - p1 ) / 2 
            Console.Write("Digite a nota da sua primeira prova: ");
            p1 = Double.Parse(Console.ReadLine());

            segnota = (3 * 5 - p1) / 2;

            if (segnota > 10)
            {
                Console.WriteLine("Nem tirando 10 você consegue ser aprovado");
            }
            else if (segnota < 0)
            {
                Console.WriteLine("Você consegue ser aprovado sem tirar nota nenhuma");
            }
            else
            {
                Console.WriteLine("Você vai precisar tirar {0} na segunda prova para ser aprovado", segnota);
            }


        }
    }
}
