using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv9M2
{
    internal class Aluno
    {
        public string nome;
        public int idade;
        public string ano;
        public string turno;

        public void Nome()
        {
            Console.WriteLine("Qual o nome do aluno?");
            nome = Console.ReadLine();
        }
        public void Idade()
        {
            Console.WriteLine("Qual a idade?");
            idade= int.Parse(Console.ReadLine());   
        }
        public void Ano()
        {
            Console.WriteLine("Em que ano está o aluno ?");
            ano = Console.ReadLine();
        }
        public void Turno()
        {
            Console.WriteLine("Qual o turno ?");
            turno = Console.ReadLine();
        }
        public void Leitor()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Ano: " + ano);
            Console.WriteLine("Turno: " + turno);
        }
    }
}