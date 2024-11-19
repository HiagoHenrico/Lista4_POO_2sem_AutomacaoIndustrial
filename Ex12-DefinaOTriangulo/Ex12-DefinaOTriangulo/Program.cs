using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_DefinaOTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();

            Console.WriteLine("Digite os três lados de um triângulo e depois classifique-o");

            Console.WriteLine("Digite o valor do lado A:");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado A:");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado A:");
            double C = Convert.ToDouble(Console.ReadLine());

            t.SetLados(A, B, C);

            if (t.EhTriangulo())
            {
                Console.WriteLine("Os valores formam um triângulo.");
                Console.WriteLine("Classificação: " + t.Classificar());
            }
            else
            {
                Console.WriteLine("Os valores não formam um triângulo.");
            }

        } 
    }
}
    

