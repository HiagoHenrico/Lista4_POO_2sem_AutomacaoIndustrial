using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_ClassificarTriangulo_WinForms
{
    internal class Triangulo
    {
        private double A;
        private double B;
        private double C;

        public void SetLadoA(double A)
        {
            this.A = A;
        }

        public void SetLadoB(double B)
        {
            this.B = B;
        }

        public void SetLadoC(double C)
        {
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
