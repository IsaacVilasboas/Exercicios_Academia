
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Atv15
{
    internal abstract class ContaBancaria
    {
        public double Saldo { get; set; }

        public ContaBancaria(double saldo)
        {
            Saldo = saldo;
        }

        public abstract void Despostiar( double valor);

        public abstract void Sacar(double valor);

    }
}