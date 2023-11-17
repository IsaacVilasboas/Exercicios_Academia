using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv9
{
    internal class Aluno
    {
        public string nome;
        public int idade;
        public string ano;
        public string turma;
        public string turno;

        public Aluno(string nome, int idade, string ano, string turma, string turno)
        {
            this.nome = nome;
            this.idade = idade;
            this.ano = ano;
            this.turma = turma;
            this.turno = turno;
        }

        public void Dados()
        {

                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Ano: " + ano);
                Console.WriteLine("Turma: " + turma);
                Console.WriteLine("Turno: " + turno);
        }
    }
}
