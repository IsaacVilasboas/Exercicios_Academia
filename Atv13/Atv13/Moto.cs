using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv13
{
    internal class Moto : Veiculo
    {
        public string Cilindradas {  get; set; }

        public Moto (string cilindradas, string marca, string modelo) : base (marca, modelo)
        {
            Cilindradas = cilindradas;
        }
        public override void Dirigir()
        {
            Console.WriteLine("Dirigindo a " + Marca + Modelo + " com " + Cilindradas + " cilindradas");
        }
    }
}
