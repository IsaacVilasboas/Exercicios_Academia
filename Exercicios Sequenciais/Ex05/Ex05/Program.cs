using System.Globalization;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double km, l, media;

            Console.WriteLine("quantos Km você PERCORREU: ");
            km = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos litros gastou: ");
            l = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            media = km / l;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture) + "l foi a média gasta de combustivel");
        }
    }
}
