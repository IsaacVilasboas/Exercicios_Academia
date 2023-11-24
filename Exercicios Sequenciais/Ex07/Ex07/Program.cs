using System.Globalization;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vendedor, salarioFixo, totalVendas, valorVenda;
            double percentualVendas, salarioTotal;

            vendedor = int.Parse(Console.ReadLine());
            salarioFixo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendas = int.Parse(Console.ReadLine());

            //O vendendor tem direito a 10% de comissão das vendas.
            percentualVendas = (totalVendas * 150.0) / 10.0;
            Console.WriteLine(percentualVendas);
            salarioTotal = salarioFixo + percentualVendas;
            Console.WriteLine("O número do vendedor é: " + vendedor + " e o seu salário total foi: " + salarioTotal);

        }
    }
}
