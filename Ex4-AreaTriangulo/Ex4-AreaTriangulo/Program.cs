using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_AreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Triangulo t = new Triangulo();

            Console.WriteLine("Calcule a área do triângulo");
            Console.WriteLine("Digite base do triângulo: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite altura do triângulo: ");
            n2 = int.Parse(Console.ReadLine());

            t.CalcularArea(n1, n2);

            Console.WriteLine("A área do triangulo é: {0}", t.getArea());
        }
    }
}
