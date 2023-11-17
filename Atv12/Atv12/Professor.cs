using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv12
{
    internal class Professor : Pessoa
    {
        public string Materia { get; set; }

        public Professor(string nome, string idade, string materia) : base(nome,idade)
        {
            Materia = materia;
        }

        public override void Apresentar()
        {
            Console.WriteLine("O professor: " + Nome + " tem " + Idade + " anos de idade e sua materia é " + Materia);
        }
    }
}
