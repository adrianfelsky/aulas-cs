using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula17
{
    public class Calculadora
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double Somar()
        {
            return Numero1 + Numero2;
        }
        public double Subtrair()
        {
            return Numero1 - Numero2;
        }
        public double Multiplicar()
        {
            return Numero1 * Numero2;
        }
        public double Dividir()
        {
            if (Numero2 == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
            return Numero1 / Numero2;
        }
    }
}
