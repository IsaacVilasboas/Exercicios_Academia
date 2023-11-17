using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    internal class Produto
    {
        private string nome;
        private double preço;
        public Fabricante Fabricante { get; set; }

        public string Nome {
            get
            {
                return nome;
            }
            set
            {
                if(!string.IsNullOrEmpty(value)) 
                {
                    nome = value;
                }
                else
                {
                    Console.WriteLine("O espaço não pode estar em branco");
                }
            }
        }
        public double Preço
        {
            get
            {
                return preço;
            }
            set
            {
                if(value >= 0)
                {
                    preço = value;
                }
                else 
                { 
                    Console.WriteLine("O valor não pode ser negativo");
                }
            }
        }
    }
}
