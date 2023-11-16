using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Produto
    {
        public string nome;
        public string preço; 
        public int quantEstoq;

        public Produto(string nome, string preço, int quantEstoq)
        {
            this.nome = nome;
            this.preço = preço;
            this.quantEstoq = quantEstoq;

        }
        public void Adc()
        {
            Console.WriteLine("Quantos produtos deseja adicionar ao estoque ?");
            int quantidade = int.Parse(Console.ReadLine());
            if (quantidade > 0) 
            {
                Console.WriteLine("Foram adicionadas ao estoque " + quantidade + " unidades de " + nome);
                quantEstoq += quantidade;
            }
            else
            {
                Console.WriteLine("Nenhuma alteração ao estoque foi realizada");
            }
            
        }
        public void Remov()
        {
            Console.WriteLine("Quantos podutos deseja remover do estoque?");
            int quantidade = int.Parse(Console.ReadLine());

            if (quantidade > 0)
            {
                Console.WriteLine("Foram removidos do estoque " + quantidade + " unidades de " + nome);
                quantEstoq -= quantidade;
            }
            else
            {
                Console.WriteLine("Nenhuma alteração ao estoque foi realizada");
            }
        }
    }

    
}
 
 

