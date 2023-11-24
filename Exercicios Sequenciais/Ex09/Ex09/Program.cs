namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preço, parcelas, entrada, resto;
            Console.WriteLine("Digite o valor do produto: ");
            preço = double.Parse(Console.ReadLine());
            resto = preço % 3.0; //302,75 resto da divisão por 3 = 2,75.
            parcelas = (preço - resto) / 3.0; // (302,75 - 2,75) / 3 = 100.
            entrada = parcelas + resto; // 100 + 2,75.

            Console.WriteLine("A entrada vai ser de " + entrada.ToString("F2") + " e o restande ficara dividido em 2x de " + parcelas.ToString("F2"));

        }
    }
}
