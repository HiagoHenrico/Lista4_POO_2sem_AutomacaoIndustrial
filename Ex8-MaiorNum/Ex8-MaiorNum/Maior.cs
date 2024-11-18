using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_MaiorNum
{
    internal class Maior
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

        public void CalcularMaior(int n1, int n2)
        {
            if(n1 > n2)
            {
                this.resultado = n1;
            }else if(n1 < n2)
            {
                this.resultado = n2;
            }
        }

        public int getMaior()
        {
            return this.resultado;
        }
    }
}
