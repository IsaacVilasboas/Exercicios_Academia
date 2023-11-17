namespace Atv02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Professor p= new Professor();
           Laboratorio p1 = new Laboratorio();
            p.nome = "Ricardo";
            p1.local = "sala 108";
            Console.WriteLine("O nome do prefessor é: " + p.nome);
            Console.WriteLine("O local da aula é: " + p1.local);

        }
    }
}