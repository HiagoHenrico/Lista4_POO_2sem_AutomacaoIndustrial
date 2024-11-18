using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_CalcRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Retangulo a = new Retangulo();

            Console.WriteLine("Calcular terreno");
            Console.Write("Digite a base do retângulo: ");
            a.setN1(int.Parse(Console.ReadLine()));
            Console.Write("Digite a altura do retângulo: ");
            a.setN2(int.Parse(Console.ReadLine()));

            

            Console.WriteLine("O terreno é {0} m²", a.CalcularArea());
            Console.WriteLine("O terreno é " + a.TamanhoTerreno());


        }
    }
}
