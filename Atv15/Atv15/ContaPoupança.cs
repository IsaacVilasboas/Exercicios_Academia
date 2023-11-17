using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv15
{
    internal class ContaPoupança : ContaBancaria
    {
        public double Saldo {  get; set; }
        public ContaPoupança(double saldo) : base(saldo)
        {
            Saldo = saldo;
        }

        public override void Despostiar(double valor)
        {
            if (Saldo > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("O valor do deposito tem que ser maior que 0");
            }
            Console.WriteLine("O seu saldo atual é: " + Saldo.ToString("F2"));
        }

        public override void Sacar(double valor)
        {
            if (Saldo > 0 && Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("O valor do Saque é maior que o Saldo");   
            }
            Console.WriteLine("O seu saldo atual é: " + Saldo.ToString("F2"));
        }
    }
}
