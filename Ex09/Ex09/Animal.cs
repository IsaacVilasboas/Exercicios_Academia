using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    internal class Animal
    {
        private string nome;
        private string especie;
        private int idade;
    
        public string Nome
        {
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
                    Console.WriteLine("O nome não pode ficar em branco");
                }
            }
        }
        public string Especie
        {
            get
            {
                return especie;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    especie = value;
                }
                else
                {
                    Console.WriteLine("O nome da Especie não pode ficar em branco");
                }
            }
        }
        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if (value >= 0)
                {
                    idade = value;
                }
                else { Console.WriteLine("A idade tem quer ser números positivos"); }
            }
        }
        public void EmitirSom()
        {
            Console.WriteLine(Nome + " está emitindo som");
        }
    } 

}
