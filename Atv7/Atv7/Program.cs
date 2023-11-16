namespace Atv7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro p = new Livro();
            p.titulo = "Olosko";
            p.autor = "Cristian";
            p.AnoFabricação = 1905;

            Console.WriteLine("Título: " + p.titulo);
            Console.WriteLine("Autor: " + p.autor );
            Console.WriteLine("Ano de Fabricação: " + p.AnoFabricação);


        }
    }
}