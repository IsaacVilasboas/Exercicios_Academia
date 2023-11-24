namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Parafuso A:");
            Console.Write("Código: ");
            int codigoA = int.Parse(Console.ReadLine());
            Console.WriteLine("Parafuso B:");
            Console.Write("Código: ");
            int codigoB = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de peças A: ");
            int quantidadeA = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de peças B: ");
            int quantidadeB = int.Parse(Console.ReadLine());

            Console.Write("Valor unitário A: ");
            double valorA = double.Parse(Console.ReadLine());

            Console.Write("Valor unitário B: ");
            double valorB = double.Parse(Console.ReadLine());

            Console.Write("Porcentagem de IPI: ");
            double ipA = double.Parse(Console.ReadLine());

            Console.Write("Porcentagem de IPI: ");
            double ipB = double.Parse(Console.ReadLine());

            double totalA = quantidadeA * valorA;
            double ipiValorA = (ipA / 100) * totalA;

            double totalB = quantidadeB * valorB;
            double ipiValorB = (ipB / 100) * totalB;

            Console.WriteLine("Resultados:");
            Console.WriteLine("Parafuso A - Total: R$ " + totalA.ToString("F2") + " , IPI: R$ " + ipiValorA.ToString("F2"));
            Console.WriteLine("Parafuso B - Total: R$ " + totalB.ToString("F2") + " , IPI: R$ " + ipiValorB.ToString("F2"));
        }
    }
}
