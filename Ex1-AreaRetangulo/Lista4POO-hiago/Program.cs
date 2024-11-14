using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4POO_hiago
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;
            AreaRetangulo ar;
            ar = new AreaRetangulo();

            Console.WriteLine("Calcule a área de um retângulo.");
            
            Console.WriteLine("Insira base: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira altura: ");
            n2 = int.Parse(Console.ReadLine());
            
            ar.CalcularArea(n1,n2);

            Console.WriteLine("Area = {0}",ar.getArea() );


        }
    }
}
