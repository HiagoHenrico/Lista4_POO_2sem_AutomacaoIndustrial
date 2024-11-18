using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_ConversaoDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;
            Cotacao c = new Cotacao();

            Console.WriteLine("Insira a cotaçao e converta dolares para reais");
            Console.Write("Digite cotação do dolar: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite valor em dolares: ");
            n2 = float.Parse(Console.ReadLine());

            c.CalcularCotacao(n1, n2);
            Console.WriteLine("Resultado: {0} USD com cotação de {1} equivale a {2} BRL", n2, n1, c.getCotacao());
        }
    }
}
