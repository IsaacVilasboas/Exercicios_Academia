using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv17
{
    internal class ContaCorrente : ContaBancaria
    {
        public double Saldo { get; set; }
        public ContaCorrente(double saldo) : base(saldo)
        {
            Saldo = saldo;
        }

        public override void Sacar(double valor)
        {
            bool Saque = true;

            if (Saque)
            {
                Saldo -= valor;
                Console.WriteLine("Primeiro Saque, gratuito");
                Saque = false;
            }
            else if (Saldo > 0 && valor < Saldo)
            {
                Saldo = Saldo - (valor  + 0.05);
            }
            else
            {
                Console.WriteLine("Você não possui valor suficiente para o saque");
            }
            base.Sacar(valor);
            Console.WriteLine("Saldo atual: " + Saldo.ToString("F2"));

        }

        public override void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("Só é possivel depositar valores maiores que 0");
            }
            base.Depositar(valor);

            Console.WriteLine("Saldo atual: " + Saldo.ToString("F2"));
        }
    }
}
