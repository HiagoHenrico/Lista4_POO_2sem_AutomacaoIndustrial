using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_MaiorNumORIgual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Maior m = new Maior();

            Console.WriteLine("Insira dois numeros e calcule o maior entre eles");
            Console.Write("Digite o 1º valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            n2 = int.Parse(Console.ReadLine());

            m.CalcularMaior();

                Console.WriteLine("O maior número é {0}", m.getMaior());

            
        }
    }
}
