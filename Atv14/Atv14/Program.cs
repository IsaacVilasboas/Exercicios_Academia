namespace Atv14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Retangulo");
            Retangulo retangulo = new Retangulo(5,7.8);
            retangulo.CalcularArea();
            retangulo.CalcularPerimentro();

            Console.WriteLine();
            Console.WriteLine("Circulo");
            Circulo circulo = new Circulo(8.5);
            circulo.CalcularArea();
            circulo.CalcularPerimentro();
        }
    }
}