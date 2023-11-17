using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv17
{
    internal abstract class ContaBancaria
    {
        public double Saldo { get; set; }

        public ContaBancaria(double saldo)
        {
            Saldo = saldo;
        }

        public  virtual void Sacar(double valor) 
        {
        }

        public virtual void Depositar(double valor) 
        {
        }
    }
}
