using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv18
{
    internal class Carro : Veiculo
    {
        public int Portas { get; set; }
        public Carro(string marca, int ano, int portas) : base(marca, ano)
        {
            Portas = portas;
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine("O carro " + Marca + " possui " + Portas + " portas");
        }
    }
}
