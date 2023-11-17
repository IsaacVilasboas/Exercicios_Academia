using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv12
{
    internal class Aluno : Pessoa
    {
        public string Matricula { get; set; }

        public Aluno(string nome, string idade, string matricula) : base( nome, idade) 
        {
            Matricula = matricula;
        }

        public override void Apresentar()
        {
            Console.WriteLine("O aluno: " + Nome + " tem " + Idade + " anos de idade e seu número de matricula é " + Matricula);
        }
    }
}
