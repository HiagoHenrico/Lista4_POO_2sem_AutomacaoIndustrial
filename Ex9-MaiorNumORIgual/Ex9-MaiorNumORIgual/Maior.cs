using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_MaiorNumORIgual
{
    internal class Maior
    {
        private int n1;
        private int n2;
        private string resultado;

        public void setN1(int n1)
        {
            this.n1 = n1;
        }

        public void setN2(int n2)
        {
            this.n2 = n2;
        }

        public void CalcularMaior()
        {
            if (n1 > n2)
            {
                this.resultado = n1.ToString();
            }
            else if (n1 < n2)
            {
                this.resultado = n2.ToString();
            }
            else if (n1 == n2)
            {
                this.resultado = "Igual";
            }

        }

        public string getMaior()
        {
            return this.resultado;
        }
    }
}
