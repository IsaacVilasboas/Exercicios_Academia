using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    internal class Fabricante
    {
        private string nome;
        public string Endereço { get; set; }
        public string Cidade { get; set; }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nome = value;
                }
                else
                {
                    Console.WriteLine("O espaço não pode estar em branco");
                }
            }
        }
    }
}
