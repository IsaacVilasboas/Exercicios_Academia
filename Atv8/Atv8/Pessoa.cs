using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv8
{
    internal class Pessoa
    {
        public string nome;
        public string cpf;
        public string dataNacimento;
        public string Rg;


        public void cadastro()
        {
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
        
            Console.WriteLine("Digite o número de seu CPF: ");
            cpf = Console.ReadLine();
       
            Console.WriteLine("Qual a sua data de nascimento: ");
            dataNacimento = Console.ReadLine();
       
            Console.WriteLine("Digite o número de seu RG:");
            Rg = Console.ReadLine();

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Data de Nascimento: " + dataNacimento);
            Console.WriteLine("RG: " + Rg);
        }
    }
}
