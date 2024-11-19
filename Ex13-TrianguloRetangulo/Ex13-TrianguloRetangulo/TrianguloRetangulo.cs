using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_TrianguloRetangulo
{
    internal class TrianguloRetangulo
    {
        private double a;
        private double b;
        private double c;

        public void SetLados(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool EhTrianguloRetangulo()
        {
            double[] lados = { a, b, c };
            Array.Sort(lados); 

            double hipotenusa = lados[2];
            double cateto1 = lados[0];
            double cateto2 = lados[1];

            return Math.Pow(hipotenusa, 2) == Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2);
        }
    }
}

