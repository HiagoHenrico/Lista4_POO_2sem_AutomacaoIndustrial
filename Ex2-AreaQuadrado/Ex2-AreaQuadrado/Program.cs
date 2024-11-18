using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_AreaQuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Quadrado q = new Quadrado();

            Console.WriteLine("Calcule a área do Quadrado");
            Console.WriteLine("Digite aresta: ");
            n1 = int.Parse(Console.ReadLine());

            q.CalcularArea(n1);

            Console.WriteLine("A área do quadrado é: {0}", q.getArea());
        }
    }
}
