using static System.Net.Mime.MediaTypeNames;

namespace Atv9
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string nome,ano,turma, turno;
             int idade;
             

            Console.WriteLine("Qual o seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade?");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Em que ano você está ?");
            ano = Console.ReadLine();
            Console.WriteLine("Em qual turma ?");
            turma = Console.ReadLine();
            Console.WriteLine("Qual o turno ?");
            turno = Console.ReadLine();

            Aluno a = new Aluno(nome, idade, ano, turma, turno);
            a.Dados();

        }
    }
}