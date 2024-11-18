using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_ConversaoDolar
{
    internal class Cotacao
    {
        private float n1;
        private float n2;
        private float resultado;

        public void setN1(float n1)
        {
            this.n1 = n1;
        }

        public void setN2(float n2)
        {
            this.n2 = n2;
        }

        public void CalcularCotacao(float n1, float n2)
        {
            this.resultado = n1 * n2;
        }

        public float getCotacao()
        {
            return this.resultado;
        }
    }
}
