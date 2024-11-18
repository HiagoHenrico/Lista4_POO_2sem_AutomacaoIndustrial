using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_CalcRetangulo
{
    internal class Retangulo
    {
        private int n1;
        private int n2;
        private Double resultado;

        public void setN1(int n1)
        {
            this.n1 = n1;
        }

        public void setN2(int n2)
        {
            this.n2 = n2;
        }

        public Double CalcularArea()
        {
           return  n1 * n2;
            
        }

        public string TamanhoTerreno()
        {
            Double area = CalcularArea();

            if (area > 100)
            {
                return "Terreno grande";

            }
            else if (area < 100)
            {
                return "Terreno pequeno";
            }
            else
            {
                return "ERRO!";
            }
        }

    }
}
