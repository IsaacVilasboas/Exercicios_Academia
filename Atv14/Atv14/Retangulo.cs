using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv14
{
    internal class Retangulo : IFormaGeometrica
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public void CalcularArea()
        {
            double Area = Largura * Altura;

            Console.WriteLine("Area: " + Area);
        }

        public void CalcularPerimentro()
        {
            double Perimentro = 2 * (Largura + Altura);
            Console.WriteLine("Perimetro: " + Perimentro);
        }
    }
}
