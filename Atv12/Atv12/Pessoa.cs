using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv12
{
    internal abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Idade { get; set; }

        public Pessoa(string nome, string idade)
        {
            Nome = nome;
            Idade = idade;

        }

        public abstract void Apresentar();

    }
}
