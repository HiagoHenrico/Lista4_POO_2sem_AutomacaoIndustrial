using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Peo
{
    internal class Peso
    {
        private double n1;
        private double n2;
        private double peso;

        public void setN1(double n1)
        {
            this.n1 = n1;
        }

        public void setN2(double n2)
        {
            this.n2 = n2;
        }

        public void PesoCidadao()
        {
            this.peso = n1 / (n2*n2);
        }

        public string CalcularPesoIdeal()
        {
            if(peso < 20)
            {
                return "Abaixo do peso";
            }else if(peso >= 20 && peso < 25){
                return "Peso Ideal";
            }else
            {
                return "Acima do Peso";
            }
        }

        public double getPeso()
        {
            return this.peso;
        }
    }
}
