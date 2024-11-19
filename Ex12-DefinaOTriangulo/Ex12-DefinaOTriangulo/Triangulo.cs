using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_DefinaOTriangulo
{
    internal class Triangulo
    {
        private double A;
        private double B;
        private double C;

        public void SetLados(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public bool EhTriangulo()
        {
            return (A + B > C) &&
                   (A + C > B) &&
                   (B + C > A);
        }

        public string Classificar()
        {
            if (A == B && B == C)
            {
                return "Equilátero";
            }
            else if (A == B || A == C || B == C)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }
    }
}
