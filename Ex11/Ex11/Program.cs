namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float validos, j, m, eleitores, nulos, brancos;
            double vvalidos, vb, vn;

            Console.WriteLine("*****ELEIÇÕES*****");
            Console.WriteLine("Quantos eleitores tem na cidade ?");

            eleitores = float.Parse(Console.ReadLine());

            Console.WriteLine("Votos nulos ?");
            Console.WriteLine("Votos em branco ?");
            Console.WriteLine("Votos em João ?");
            Console.WriteLine("Votos em Maria ?");

            nulos = float.Parse(Console.ReadLine());
            brancos = float.Parse(Console.ReadLine()); // votos / eleitores * 100
            j = float.Parse(Console.ReadLine());
            m = float.Parse(Console.ReadLine());

            validos = j + m;

            vb = brancos / eleitores * 100.0;
            vn = nulos / eleitores * 100.0;
            vvalidos = validos / eleitores * 100.0;

            Console.WriteLine("Votos validos são " + vvalidos.ToString("F0") + "% dos votos da eleição");
            Console.WriteLine("Votos validos são " + vn.ToString("F0") + "% dos votos da eleição");
            Console.WriteLine("Votos validos são " + vb.ToString("F0") + "% dos votos da eleição");
        }
    }
}