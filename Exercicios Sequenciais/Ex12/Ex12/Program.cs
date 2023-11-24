namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Km, Kmf, Kmtotal;
            double lgastos, mediaConsumo, lucro, valorRecebido;

            Console.WriteLine("Qual o km inicial ?");
            Console.WriteLine("Qual o km final ?");
            Km = int.Parse(Console.ReadLine());
            Kmf = int.Parse(Console.ReadLine());
            Kmtotal = Kmf - Km;

            Console.WriteLine("Quantos km o carro faz com um Litro de gasolina ?");
            lgastos = int.Parse(Console.ReadLine());
            mediaConsumo = Kmtotal / lgastos;

            Console.WriteLine("Recebeu quanto em dinheiro ?");
            valorRecebido = int.Parse(Console.ReadLine());

            lucro = valorRecebido - (lgastos * 6.90);

            Console.WriteLine(Kmtotal);
            Console.WriteLine(mediaConsumo.ToString("F1"));
            Console.WriteLine(lucro.ToString("F2"));
        }
    }
}