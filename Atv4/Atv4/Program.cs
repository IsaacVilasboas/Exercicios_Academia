namespace Atv4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogo p = new Jogo();
            Console.WriteLine("Qual o Título do jogo?");
            p.titulo = Console.ReadLine();
            Console.WriteLine("Qual o Gênero?");
            p.genero = Console.ReadLine();
            Console.WriteLine("Qual a plataforma?");
            p.plataforma = Console.ReadLine();
            Console.WriteLine("Qual foi o ano de seu lançamento?");
            p.lançamento = int.Parse(Console.ReadLine());
            Console.WriteLine("Título: " + p.titulo);
            Console.WriteLine("Gênero: " + p.genero);
            Console.WriteLine("Plataforma: " + p.plataforma);
            Console.WriteLine("Lançamento: " + p.lançamento);
        }
    }
}