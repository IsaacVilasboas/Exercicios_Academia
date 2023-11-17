using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv14
{
    internal class Circulo : IFormaGeometrica
    {
        public double Raio {  get; set; }

        public Circulo(double raio) 
        {
            Raio = raio;
        }
        public void CalcularArea()
        {
            double Area = 3.14 * Raio * Raio;
            Console.WriteLine("Area: " + Area);
        }

        public void CalcularPerimentro()
        {
            double Perimentro =  2 * 3.14 * Raio;
            Console.WriteLine("Perimetro: " +  Perimentro);
        }
    }
}
