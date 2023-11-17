using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv18
{
    internal class Moto : Veiculo
    {
        public int Cilindradas { get; set; }
        public Moto(string marca, int ano, int cilindradas) : base(marca, ano)
        {
            Cilindradas = cilindradas;
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine("A moto da marca: " + Marca + " possui " + Cilindradas + " Cilindradas");
        }
    }
}
