using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Peo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double n1, n2;
            Peso p = new Peso();
            Console.WriteLine("Calcule o peso ideal de um indivíduo");

            Console.WriteLine("Digite o peso em KG: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            p.setN1(n1);

            Console.Write("Digite a altura em M: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            p.setN1(n2);
            p.CalcularPesoIdeal();
            Console.Write("Peso: {0} - Altura: {1}", n1, n2);
            Console.Write(" Você está: " + p.getPeso());

        }
    }
}

