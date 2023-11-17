using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv17
{
    internal class Conta_Poupança : ContaBancaria
    {
        public double Saldo { get; set; }
        public Conta_Poupança(double saldo) : base(saldo)
        {
            Saldo = saldo;
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
        public override void Sacar(double valor)
        {
            if (Saldo > 0 && valor < Saldo)
            {
                Saldo = Saldo - (valor + 0.10);
            }
            else
            {
                Console.WriteLine("Você não possui valor suficiente para o saque");
            }
            base.Sacar(valor);
            Console.WriteLine("Saldo atual: " + Saldo.ToString("F2"));
        }
    }
}
