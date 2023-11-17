using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv13
{
    internal class Carro : Veiculo
    {
        public string Portas { get; set; }

        public Carro (string portas, string marca, string modelo) : base (marca, modelo)
        {
            Portas = portas;
        }

        public override void Dirigir()
        {
            Console.WriteLine("Dirigindo o " + Marca + Modelo + " com " + Portas + " Portas.");
        }
    }
}
