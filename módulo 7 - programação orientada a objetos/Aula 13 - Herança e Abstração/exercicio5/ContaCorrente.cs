using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula13.exercicio5
{
    class ContaCorrente : Conta
    {
        public double TaxaManutencao = 0.05;
        public ContaCorrente(double saldo) : base(saldo)
        {
            Saldo = saldo;
        }
    }
}
