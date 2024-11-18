using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_AreaTriangulo
{
    internal class Triangulo
    {
        private int n1;
        private int n2;
        private int resultado;

        public void setN1(int n1)
        {
            this.n1 = n1;
        }

        public void setN2(int n2)
        {
            this.n2 = n2;
        }

        public void CalcularArea(int n1, int n2)
        {
            this.resultado = (n1 * n2) / 2;
        }

        public int getArea()
        {
            return this.resultado;
        }
    }
}
