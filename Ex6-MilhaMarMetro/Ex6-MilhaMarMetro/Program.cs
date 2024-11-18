using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_MilhaMarMetro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1;
            Milhas m = new Milhas();
            Console.WriteLine("Coverta milhas para metros");
            Console.Write("Digite milha: ");
            n1 = int.Parse(Console.ReadLine());
            m.CalcularDistancia(n1);
            Console.WriteLine("Resultado: {0} em milhas equivale á {1} quilómetros",n1, m.getDistancia());

        }
    }
}
