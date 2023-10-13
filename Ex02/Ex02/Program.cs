using System.Globalization;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a + b + c + d) / 4.0;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}

