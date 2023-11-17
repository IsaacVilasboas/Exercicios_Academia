using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    internal class Carro
    {
        private string modelo;
        private string ano;
        private int velocidade;

       public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    modelo = value;
                }
                else
                {
                    Console.WriteLine("Espaço não pode ficar em branco");
                }
            }
        }
        public string Ano
        {
            get
            {
                return ano;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    ano = value;
                }
                else
                {
                    Console.WriteLine("Espaço não pode ficar em branco");
                }
            }
        }


        public int Velocidade
        {
            get
            {
                return velocidade;
            }
            set
            {
                if(value >= 0)
                {
                    velocidade = value;
                }
                else
                {
                    Console.WriteLine("Velocidade não pode ser negativa");
                }
            }
        }
        

        public void Acelerar()
        {
            Velocidade += 10;
        }
        public void Reduzir()
        {
            Velocidade -= 10;
        }
    }
}
//Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade". Em seguida, crie um método para acelerar o carro (aumentando a velocidade em 10) e outro para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a  velocidade negativa).

