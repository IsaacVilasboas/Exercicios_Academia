using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class RegistroDeCompras
    {
        public string data;
        public string produto;
        public string valor;

        public RegistroDeCompras(string data, string produto, string valor)
        {
            this.data = data;
            this.produto = produto;
            this.valor = valor;
        }
        
       
        public void AdCompra()
        {
            Console.WriteLine("Qual foi a data da compra ?");
            string data = Console.ReadLine();
            Console.WriteLine("Qual foi o nome do produto?");
            string produto = Console.ReadLine();
            Console.WriteLine("Qual o valor ?");
            string valor = Console.ReadLine();
        }
    }
}
