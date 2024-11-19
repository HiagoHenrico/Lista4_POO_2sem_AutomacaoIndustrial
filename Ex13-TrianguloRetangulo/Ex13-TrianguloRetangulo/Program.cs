using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_TrianguloRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrianguloRetangulo triangulo = new TrianguloRetangulo();

            Console.WriteLine("Digite o valor do lado A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado B:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado C:");
            double c = Convert.ToDouble(Console.ReadLine());

            triangulo.SetLados(a, b, c);

            if (triangulo.EhTrianguloRetangulo())
            {
                Console.WriteLine("Os valores formam um triângulo retângulo.");
            }
            else
            {
                Console.WriteLine("Os valores não formam um triângulo retângulo.");
            }
        }
    }
}
