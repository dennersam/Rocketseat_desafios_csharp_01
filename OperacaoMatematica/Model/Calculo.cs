using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacaoMatematica.Model
{
    internal class Calculo
    {

        public double Soma(double numero1, double numero2) => numero1 + numero2;

        public double Subtracao(double numero1, double numero2) => numero1 - numero2;

        public double Multiplicacao(double numero1, double numero2) => numero1 * numero2;

        public double Divisao(double numero1, double numero2)
        {
            if(numero2 == 0) return 0;
            return numero1 / numero2;
        }

        public double Media(double numero1, double numero2)
        {
            if (numero2 == 0) return 0;
            return numero1 * numero2 / 2;
        }

    }
}
